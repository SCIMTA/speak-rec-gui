import pandas as pd
from fastapi import FastAPI
from pydantic import BaseModel

from exam import feature_extract
from main import run_main

app = FastAPI()
path_database_emb = './data/emb.csv'
path_database_person = './data/person.csv'
path_database_join = './data/join.csv'


class GenSub(BaseModel):
    meeting: str


class AddPerson(BaseModel):
    audio: str
    label: str


class EditJoin(BaseModel):
    label: str
    is_check: bool


class RemovePerson(BaseModel):
    label: str


@app.post("/add_person")
def add_person(body: AddPerson):
    path_file = body.audio
    label = body.label

    database_person = pd.read_csv(path_database_person)
    database_person = database_person.append(pd.DataFrame({
        "label": [label]
    }))
    database_person.to_csv(path_database_person, index=False)

    database_join = pd.read_csv(path_database_join)
    database_join = database_join.append(pd.DataFrame({
        "label": [label]
    }))
    database_join.to_csv(path_database_join, index=False)

    list_emb = feature_extract(path_file, True)
    database_emb = pd.read_csv(path_database_emb)
    for emb in list_emb:
        new_person = pd.DataFrame({
            "label": [label],
            "emb": [str(list(emb))]
        })
        database_emb = database_emb.append(new_person)
    database_emb.to_csv(path_database_emb, index=False)
    return {
        "label": label,
    }


@app.post("/gen_sub")
def gen_sub(body: GenSub):
    meeting = body.meeting
    output = run_main(meeting)
    return {
        "path": output,
    }


@app.get("/get_list_person")
def get_list_peron():
    data = pd.read_csv(path_database_person).values.tolist()
    data = [{"name": x[-1]} for x in data]
    return {
        "data": data
    }


@app.get("/get_list_join")
def get_list_join():
    data = pd.read_csv(path_database_join).values.tolist()
    data = [{"name": x[-1]} for x in data]
    return {
        "data": data
    }


@app.post("/remove_person")
def add_join(body: RemovePerson):
    database_person = pd.read_csv(path_database_person)
    database_person = database_person[database_person['label'] != body.label]
    database_person.to_csv(path_database_person, index=False)

    database_join = pd.read_csv(path_database_join)
    database_join = database_join[database_join['label'] != body.label]
    database_join.to_csv(path_database_join, index=False)

    database_emb = pd.read_csv(path_database_emb)
    database_emb = database_emb[database_emb['label'] != body.label]
    database_emb.to_csv(path_database_emb, index=False)
    return {
        "label": body.label
    }


@app.post("/edit_join")
def add_join(body: EditJoin):
    database_join = pd.read_csv(path_database_join, delim_whitespace=True)
    database_join = database_join[database_join['label'] != body.label]
    if body.is_check:
        database_join = database_join.append(pd.DataFrame({
            "label": [body.label]
        }))
    database_join.to_csv(path_database_join, index=False)
    return {
        "label": body.label
    }


@app.post("/clear_join")
def clear_join():
    database_join = pd.read_csv(path_database_join, delim_whitespace=True)
    database_join = database_join[database_join['label'] == "/"]
    database_join.to_csv(path_database_join, index=False)
    return {
        "label": "Thành công"
    }
