import logging
import os
import re
from glob import glob


# import matplotlib.pyplot as plt


def natural_sort(l):
    convert = lambda text: int(text) if text.isdigit() else text.lower()
    alphanum_key = lambda key: [convert(c) for c in re.split('([0-9]+)', key)]
    return sorted(l, key=alphanum_key)


def get_last_checkpoint_if_any(checkpoint_folder):
    os.makedirs(checkpoint_folder, exist_ok=True)
    files = glob('{}/*.h5'.format(checkpoint_folder), recursive=True)
    if len(files) == 0:
        return None
    return natural_sort(files)[-1]


def create_dir_and_delete_content(directory):
    os.makedirs(directory, exist_ok=True)
    files = sorted(filter(lambda f: os.path.isfile(f) and f.endswith(".h5"),
                          map(lambda f: os.path.join(directory, f), os.listdir(directory))),
                   key=os.path.getmtime)
    # delete all but most current file to assure the latest model is availabel even if process is killed
    for file in files[:-4]:
        logging.info("removing old model: {}".format(file))
        os.remove(file)
