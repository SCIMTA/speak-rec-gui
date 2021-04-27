import librosa
import numpy as np

import constants as c
from load_model import model
from pre_process import extract_features, read_audio, VAD


def clipped_audio(x, num_frames=c.NUM_FRAMES):
    if x.shape[0] > num_frames + 20:
        bias = np.random.randint(20, x.shape[0] - num_frames)
        clipped_x = x[bias: num_frames + bias]
    elif x.shape[0] > num_frames:
        bias = np.random.randint(0, x.shape[0] - num_frames)
        clipped_x = x[bias: num_frames + bias]
    else:
        clipped_x = x

    return clipped_x


def split_audio(features, num_frames=c.NUM_FRAMES):
    p = (features.shape[0] - num_frames) / num_frames + 1
    output_array = []
    for i in range(int(p)):
        try:
            start = int(i * num_frames)
            end = int((i + 1) * num_frames)
            feature = features[start:end]
            output_array.append(feature)
        except:
            print("vao exception trong split_audio roi")
    if int(p) == 0:
        return [features]
    return output_array


def feature_extract(full_path, is_add_person=False):
    if is_add_person:
        list_feature_extracted = []
        raw_audios = split_and_overlap(full_path)
        for audio in raw_audios:
            feature_extracted = extract_features(audio, target_sample_rate=c.SAMPLE_RATE)
            feature_extracted = clipped_audio(feature_extracted)
            # feature_extracted = feature_extracted[np.newaxis, ...]
            list_feature_extracted.append(feature_extracted)

        predict_emb = model.predict(np.array(list_feature_extracted))
    else:
        raw_audio = read_audio(full_path)
        feature_extracted = extract_features(raw_audio, target_sample_rate=c.SAMPLE_RATE)
        feature_extracted = clipped_audio(feature_extracted)
        feature_extracted = feature_extracted[np.newaxis, ...]
        predict_emb = model.predict(feature_extracted)

    return predict_emb


def split_and_overlap(filename, sample_rate=c.SAMPLE_RATE
                      , alpha=0.5):
    main_audio, sr = librosa.load(filename, sr=sample_rate, mono=True)
    main_audio = VAD(main_audio.flatten())
    start_sec, end_sec = c.TRUNCATE_SOUND_SECONDS
    start_frame = int(start_sec * c.SAMPLE_RATE)
    main_audio = main_audio[start_frame:]
    len_frame = int(1.61 * 16000)
    overlap = len_frame * (1 - alpha)
    overlapped_frame = len_frame - overlap
    p = (len(main_audio) - len_frame) / overlapped_frame + 1
    audios = []
    for i in range(int(p)):
        if i < c.MAX_FEATURE_EXTRA:
            start = int(i * overlapped_frame)
            end = int(i * overlapped_frame + len_frame)
            audio = main_audio[start:end]
            audios.append(audio)
    return audios
