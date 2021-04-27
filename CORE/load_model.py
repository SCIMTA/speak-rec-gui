import constants as c
from models import convolutional_model
from utils import get_last_checkpoint_if_any

model = convolutional_model()
last_checkpoint = get_last_checkpoint_if_any(c.CHECKPOINT_FOLDER)
print(last_checkpoint)
model.load_weights(last_checkpoint)
