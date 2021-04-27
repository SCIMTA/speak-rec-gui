"""
Defines autosub's main functionality.
"""

# !/usr/bin/env python

from __future__ import absolute_import, print_function, unicode_literals

import argparse
import audioop
import json
import math
import multiprocessing
import os
import subprocess
import tempfile
import wave

import pandas as pd
import requests

import constants as c
from exam import feature_extract
from test_model import batch_cosine_similarity

try:
    from json.decoder import JSONDecodeError
except ImportError:
    JSONDecodeError = ValueError

from googleapiclient.discovery import build
from progressbar import ProgressBar, Percentage, Bar, ETA

from constants import (
    LANGUAGE_CODES, GOOGLE_SPEECH_API_KEY, GOOGLE_SPEECH_API_URL,
)
from formatters import FORMATTERS

DEFAULT_SUBTITLE_FORMAT = 'srt'
DEFAULT_CONCURRENCY = 1
DEFAULT_SRC_LANGUAGE = 'vi'
DEFAULT_DST_LANGUAGE = 'vi'
DEFAULT_OUTPUT = "data/video.srt"
# SOURCE_PATH = "data/video.mp4"


def write_file(data, filename):
    # Convert binary data to proper format and write it on Hard Disk
    with open(filename, "wb") as file:
        file.write(data)


def percentile(arr, percent):
    """
    Calculate the given percentile of arr.
    """
    arr = sorted(arr)
    index = (len(arr) - 1) * percent
    floor = math.floor(index)
    ceil = math.ceil(index)
    if floor == ceil:
        return arr[int(index)]
    low_value = arr[int(floor)] * (ceil - index)
    high_value = arr[int(ceil)] * (index - floor)
    return low_value + high_value


class SR(object):
    """
    class for indenficating a region of a input audio
    """

    def __init__(self, source_path, include_before=0, include_after=0):
        self.source_path = source_path
        self.include_before = include_before
        self.include_after = include_after

    def __call__(self, region):
        try:
            result = {}
            start, end = region
            start = max(0, start - self.include_before)
            end += self.include_after
            temp = tempfile.NamedTemporaryFile(suffix='.wav', delete=False)
            command = ["ffmpeg", "-ss", str(start), "-t", str(end - start),
                       "-y", "-i", self.source_path,
                       "-loglevel", "error", temp.name]
            use_shell = True if os.name == "nt" else False
            subprocess.check_output(command, stdin=open(os.devnull), shell=use_shell)
            feature = feature_extract(temp.name)

            join_values = pd.read_csv('./data/join.csv').values.T[0]
            c.FEATURES = pd.read_csv('./data/emb.csv').values

            for item in c.FEATURES:
                speaker, feature_item = item
                if speaker in join_values:
                    feature_item = list(feature_item[1:-1].split(","))
                    feature_item = list(map(lambda x: float(x), feature_item))
                    similarity = batch_cosine_similarity(feature, feature_item)
                    similarity = similarity[0]
                    try:
                        result[speaker] += similarity / c.MAX_FEATURE_EXTRA
                    except KeyError:
                        result[speaker] = similarity / c.MAX_FEATURE_EXTRA
            sorted_score = sorted(result.items(), key=lambda x: x[1], reverse=True)
            print("label: {}".format(sorted_score[0][0]))

            # os.unlink(temp.name)
            temp.close()
            return sorted_score[0][0]
        except KeyboardInterrupt:
            return None


class FLACConverter(object):  # pylint: disable=too-few-public-methods
    """
    Class for converting a region of an input audio or video file into a FLAC audio file
    """

    def __init__(self, source_path, include_before=0.25, include_after=0.25):
        self.source_path = source_path
        self.include_before = include_before
        self.include_after = include_after

    def __call__(self, region):
        try:
            start, end = region
            start = max(0, start - self.include_before)
            end += self.include_after
            temp = tempfile.NamedTemporaryFile(suffix='.flac', delete=False)
            command = ["ffmpeg", "-ss", str(start), "-t", str(end - start),
                       "-y", "-i", self.source_path,
                       "-loglevel", "error", temp.name]
            use_shell = True if os.name == "nt" else False
            subprocess.check_output(command, stdin=open(os.devnull), shell=use_shell)
            read_data = temp.read()
            temp.close()
            os.unlink(temp.name)
            # print("readed_audio {}".format(read_data))
            return read_data

        except KeyboardInterrupt:
            return None


class SpeechRecognizer(object):  # pylint: disable=too-few-public-methods
    """
    Class for performing speech-to-text for an input FLAC file.
    """

    def __init__(self, language="en", rate=16000, retries=3, api_key=GOOGLE_SPEECH_API_KEY):
        self.language = language
        self.rate = rate
        self.api_key = api_key
        self.retries = retries

    def __call__(self, data):
        try:
            for _ in range(self.retries):
                url = GOOGLE_SPEECH_API_URL.format(lang=self.language, key=self.api_key)
                headers = {"Content-Type": "audio/x-flac; rate=%d" % self.rate}

                try:
                    resp = requests.post(url, data=data, headers=headers)
                except requests.exceptions.ConnectionError:
                    continue

                for line in resp.content.decode('utf-8').split("\n"):
                    try:
                        line = json.loads(line)
                        line = line['result'][0]['alternative'][0]['transcript']
                        return line[:1].upper() + line[1:]
                    except IndexError:
                        # no result
                        continue
                    except JSONDecodeError:
                        continue

        except KeyboardInterrupt:
            return None


class Translator(object):  # pylint: disable=too-few-public-methods
    """
    Class for translating a sentence from a one language to another.
    """

    def __init__(self, language, api_key, src, dst):
        self.language = language
        self.api_key = api_key
        self.service = build('translate', 'v2',
                             developerKey=self.api_key)
        self.src = src
        self.dst = dst

    def __call__(self, sentence):
        try:
            if not sentence:
                return None

            result = self.service.translations().list(  # pylint: disable=no-member
                source=self.src,
                target=self.dst,
                q=[sentence]
            ).execute()

            if 'translations' in result and result['translations'] and \
                    'translatedText' in result['translations'][0]:
                return result['translations'][0]['translatedText']

            return None

        except KeyboardInterrupt:
            return None


def which(program):
    """
    Return the path for a given executable.
    """

    def is_exe(file_path):
        """
        Checks whether a file is executable.
        """
        return os.path.isfile(file_path) and os.access(file_path, os.X_OK)

    fpath, _ = os.path.split(program)
    if fpath:
        if is_exe(program):
            return program
    else:
        for path in os.environ["PATH"].split(os.pathsep):
            path = path.strip('"')
            exe_file = os.path.join(path, program)
            if is_exe(exe_file):
                return exe_file
    return None


def extract_audio(filename, channels=1, rate=16000):
    """
    Extract audio from an input file to a temporary WAV file.
    """
    temp = tempfile.NamedTemporaryFile(suffix='.wav', delete=False)
    if not os.path.isfile(filename):
        print("The given file does not exist: {}".format(filename))
        raise Exception("Invalid filepath: {}".format(filename))
    if not which("ffmpeg.exe"):
        print("ffmpeg: Executable not found on machine.")
        raise Exception("Dependency not found: ffmpeg")
    command = ["ffmpeg", "-y", "-i", filename,
               "-ac", str(channels), "-ar", str(rate),
               "-loglevel", "error", temp.name]
    use_shell = True if os.name == "nt" else False
    subprocess.check_output(command, stdin=open(os.devnull), shell=use_shell)
    return temp.name, rate


def find_speech_regions(filename, frame_width=4096, min_region_size=0.5,
                        max_region_size=10):  # pylint: disable=too-many-locals
    """
    Perform voice activity detection on a given audio file.
    """
    reader = wave.open(filename)
    sample_width = reader.getsampwidth()
    rate = reader.getframerate()
    n_channels = reader.getnchannels()
    chunk_duration = float(frame_width) / rate

    n_chunks = int(math.ceil(reader.getnframes() * 1.0 / frame_width))
    energies = []

    for _ in range(n_chunks):
        chunk = reader.readframes(frame_width)
        energies.append(audioop.rms(chunk, sample_width * n_channels))

    threshold = percentile(energies, 0.2)

    elapsed_time = 0

    regions = []
    region_start = None

    for energy in energies:
        is_silence = energy <= threshold
        max_exceeded = region_start and elapsed_time - region_start >= max_region_size

        if (max_exceeded or is_silence) and region_start:
            if elapsed_time - region_start >= min_region_size:
                regions.append((region_start, elapsed_time))
                region_start = None

        elif (not region_start) and (not is_silence):
            region_start = elapsed_time
        elapsed_time += chunk_duration
    print(regions)
    return regions


def generate_subtitles(  # pylint: disable=too-many-locals,too-many-arguments
        source_path,
        output=None,
        concurrency=DEFAULT_CONCURRENCY,
        src_language=DEFAULT_SRC_LANGUAGE,
        dst_language=DEFAULT_DST_LANGUAGE,
        subtitle_file_format=DEFAULT_SUBTITLE_FORMAT,
        api_key=None,
):
    """
    Given an input audio/video file, generate subtitles in the specified language and format.
    """
    audio_filename, audio_rate = extract_audio(source_path)
    print("audio_filename: {}".format(audio_filename))
    regions = find_speech_regions(audio_filename)

    pool = multiprocessing.Pool(concurrency)
    converter = FLACConverter(source_path=audio_filename)
    recognizer = SpeechRecognizer(language=src_language, rate=audio_rate,
                                  api_key=GOOGLE_SPEECH_API_KEY)
    speaker_recognizer = SR(source_path=audio_filename)
    transcripts = []
    regions_update = []
    labels_update = []
    if regions:
        try:
            labels = []
            for region in regions:
                label = speaker_recognizer(region)
                labels.append(label)
            print("Labels {}:".format(labels))

            _label = []
            items = []
            labels_update = []
            start = None
            end = None
            i = 0
            for index, label in enumerate(labels):
                if len(_label) == 0:
                    _label.append(label)
                    start = index
                    labels_update.append(label)
                    i = i + 1
                elif label in _label and i < 10:
                    end = index
                    i = i + 1
                else:
                    item = (start, end)
                    items.append(item)
                    _label = []
                    _label.append(label)
                    start = index
                    end = None
                    labels_update.append(label)
                    i = 0
            print("items {}".format(items))
            print("labels {}".format(labels))
            print("labels_update {}".format(labels_update))
            for item in items:
                if item[1] == None:
                    start, end = regions[item[0]]
                    regions_update.append((start, end))
                else:
                    start1, end1 = regions[item[0]]
                    start2, end2 = regions[item[1]]
                    regions_update.append((start1, end2))
            print("regions_update {}".format(regions_update))
            widgets = ["Converting speech regions to FLAC files: ", Percentage(), ' ', Bar(), ' ',
                       ETA()]
            process_bar = ProgressBar(widgets=widgets, maxval=len(regions_update)).start()
            extracted_regions = []
            for i, extracted_region in enumerate(pool.imap(converter, regions_update)):
                extracted_regions.append(extracted_region)
                process_bar.update(i)
            process_bar.finish()

            widgets = ["Performing speech recognition: ", Percentage(), ' ', Bar(), ' ', ETA()]
            process_bar.widgets = widgets
            process_bar.maxval = len(regions_update)
            process_bar.start()
            for i, transcript in enumerate(pool.imap(recognizer, extracted_regions)):
                transcripts.append(transcript)
                process_bar.update(i)
            print("transcripts {}".format(transcripts))
            process_bar.finish()
            if src_language.split("-")[0] != dst_language.split("-")[0]:
                if api_key:
                    google_translate_api_key = api_key
                    translator = Translator(dst_language, google_translate_api_key,
                                            dst=dst_language,
                                            src=src_language)
                    prompt = "Translating from {0} to {1}: ".format(src_language, dst_language)
                    widgets = [prompt, Percentage(), ' ', Bar(), ' ', ETA()]
                    process_bar.widgets = widgets
                    process_bar.maxval = len(regions_update)
                    process_bar.start()
                    translated_transcripts = []
                    for i, transcript in enumerate(pool.imap(translator, transcripts)):
                        translated_transcripts.append(transcript)
                        process_bar.update(i)
                    process_bar.finish()
                    transcripts = translated_transcripts
                else:
                    print(
                        "Error: Subtitle translation requires specified Google Translate API key. "
                        "See --help for further information."
                    )
                    return 1

        except KeyboardInterrupt:
            process_bar.finish()
            pool.terminate()
            pool.join()
            print("Cancelling transcription")
            raise

    timed_subtitles = [(r, t, l) for r, t, l in zip(regions_update, labels_update, transcripts) if t]
    formatter = FORMATTERS.get(subtitle_file_format)
    formatted_subtitles = formatter(timed_subtitles)
    print("formatted_subtitles {}: ".format(formatted_subtitles))
    # dest = output

    # if not dest:
    #     base = os.path.splitext(source_path)[0]
    #     dest = "{base}.{format}".format(base=base, format=subtitle_file_format)

    with open(output, 'wb') as output_file:
        output_file.write(formatted_subtitles.encode("utf-8"))

    os.remove(audio_filename)

    return output


def validate(args):
    """
    Check that the CLI arguments passed to autosub are valid.
    """
    if args.format not in FORMATTERS:
        print(
            "Subtitle format not supported. "
            "Run with --list-formats to see all supported formats."
        )
        return False

    if args.src_language not in LANGUAGE_CODES.keys():
        print(
            "Source language not supported. "
            "Run with --list-languages to see all supported languages."
        )
        return False

    if args.dst_language not in LANGUAGE_CODES.keys():
        print(
            "Destination language not supported. "
            "Run with --list-languages to see all supported languages."
        )
        return False

    if not args.source_path:
        print("Error: You need to specify a source path.")
        return False

    return True


def main(path_file):
    """
    Run autosub as a command-line program.
    """
    print(path_file)
    parser = argparse.ArgumentParser()
    parser.add_argument('--source_path', help="Path to the video or audio file to subtitle",
                        nargs='?', default=path_file)
    parser.add_argument('-C', '--concurrency', help="Number of concurrent API requests to make",
                        type=int, default=DEFAULT_CONCURRENCY)
    parser.add_argument('-o', '--output',
                        help="Output path for subtitles (by default, subtitles are saved in \
                        the same directory and name as the source path)", default=DEFAULT_OUTPUT)
    parser.add_argument('-F', '--format', help="Destination subtitle format",
                        default=DEFAULT_SUBTITLE_FORMAT)
    parser.add_argument('-S', '--src-language', help="Language spoken in source file",
                        default=DEFAULT_SRC_LANGUAGE)
    parser.add_argument('-D', '--dst-language', help="Desired language for the subtitles",
                        default=DEFAULT_DST_LANGUAGE)
    parser.add_argument('-K', '--api-key',
                        help="The Google Translate API key to be used. \
                        (Required for subtitle translation)")
    parser.add_argument('--list-formats', help="List all available subtitle formats",
                        action='store_true')
    parser.add_argument('--list-languages', help="List all available source/destination languages",
                        action='store_true')

    args = parser.parse_args()

    if args.list_formats:
        print("List of formats:")
        for subtitle_format in FORMATTERS:
            print("{format}".format(format=subtitle_format))
        return 0

    if args.list_languages:
        print("List of all languages:")
        for code, language in sorted(LANGUAGE_CODES.items()):
            print("{code}\t{language}".format(code=code, language=language))
        return 0

    if not validate(args):
        return 1

    try:
        subtitle_file_path = generate_subtitles(
            source_path=args.source_path,
            concurrency=args.concurrency,
            src_language=args.src_language,
            dst_language=args.dst_language,
            api_key=args.api_key,
            subtitle_file_format=args.format,
            output=args.output,
        )
        print("Subtitles file created at {}".format(subtitle_file_path))
        return subtitle_file_path
    except KeyboardInterrupt:
        return 1


def run_main(path):
    root_path = "\\".join(path.split("\\")[:-1]) + "\\"
    output_path = root_path + str(path.split("\\")[-1]).split(".")[-2] + ".srt"
    try:
        subtitle_file_path = generate_subtitles(
            source_path=path,
            concurrency=DEFAULT_CONCURRENCY,
            src_language=DEFAULT_SRC_LANGUAGE,
            dst_language=DEFAULT_DST_LANGUAGE,
            api_key=GOOGLE_SPEECH_API_KEY,
            subtitle_file_format=DEFAULT_SUBTITLE_FORMAT,
            output=output_path,
        )
        print("Subtitles file created at {}".format(subtitle_file_path))
        return subtitle_file_path
    except KeyboardInterrupt:
        return 1
