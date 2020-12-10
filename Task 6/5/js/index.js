
'use strict';

let blindFlag = false;
let deleteButtonFlag = false;
let currentNoteId;

const modalWindowId = 'modal-window';
const noteTitleClass = 'note-title';
const noteTextClass = 'note-text';
const deleteNoteButtonClass = 'delete-note-button';
const newNoteTitleId = 'new-note-title';
const newNoteTextId = 'new-note-text';
const changeNoteTitleId = 'change-note-title';
const changeNoteTextId = 'change-note-text';



var notesCollection = new Service();


function Note(title, text) {
    this.title = title;
    this.text = text;
}


function createNoteNode(note, id){

    let newNote = document.createElement('div');
    newNote.className = 'note';
    newNote.id = id;

    let noteTitle = document.createElement('div');
    noteTitle.className = 'note-title';
    noteTitle.innerHTML = note.title;
    noteTitle.setAttribute('onclick', 'openChangeNoteWindow(this)');

    let noteText = document.createElement('div');
    noteText.className = 'note-text';
    noteText.innerHTML = note.text;
    noteText.setAttribute('onclick', 'openChangeNoteWindow(this)');

    let deleteNoteWrapper = document.createElement('div');
    deleteNoteWrapper.className = 'delete-note-wrapper';
    deleteNoteWrapper.setAttribute('onclick', 'openChangeNoteWindow(this)');

    let noteDeleteButton = document.createElement('div');
    noteDeleteButton.className = 'delete-note-button';
    noteDeleteButton.setAttribute('onclick', 'deleteNote(this)');

    let deleteImage = document.createElement('img');
    deleteImage.src = "images/bin.png";
    deleteImage.alt = "delete button";

    noteDeleteButton.append(deleteImage);
    deleteNoteWrapper.append(noteDeleteButton);

    newNote.append(noteTitle);
    newNote.append(noteText);
    newNote.append(deleteNoteWrapper);


    return newNote;
}




function addNewNote() {

    let newNote = getNewNoteData();

    if(emptyNote(newNote)){
        return;
    }

    let newNoteId = notesCollection.add(newNote);

    let newNoteNode = createNoteNode(newNote, newNoteId);


    let notes = document.getElementById("notes-wrapper");
    notes.prepend(newNoteNode);
    closeModalWindow();
    clearInput();

}


function deleteNote(node){
    deleteFlag();

    if (confirm("Delete this note?")){
        
        notesCollection.deleteById(node.parentNode.parentNode.id);
        node.parentNode.parentNode.remove();
    }
}

function openChangeNoteWindow(node){

    if(deleteButtonFlag){
        deleteButtonFlag = false;
        return;
    }

    let noteId = node.parentNode.id;

    let noteData = notesCollection.getById(noteId);

    document.getElementById(changeNoteTitleId).value = noteData.title;
    document.getElementById(changeNoteTextId).value = noteData.text;

    openModalWindow('change');

    currentNoteId = noteId;


}

function changeNote(){

    let changedNote = getChangeNoteData();

    if (emptyNote(changedNote)){
        return;
    }

    notesCollection.updateById(currentNoteId, changedNote);

    document.getElementById(currentNoteId).remove();

    let newNoteNode = createNoteNode(changedNote, currentNoteId);

    let notes = document.getElementById("notes-wrapper");
    notes.prepend(newNoteNode);
    closeModalWindow();
    clearInput();


}


function emptyNote(note) {
    return (!note.title && !note.text);
}

function getNewNoteData(){
    
    let title = getNewTitle();
    let text = getNewText();

    return new Note(title, text);
}

function getNewTitle(){
    return document.getElementById(newNoteTitleId).value;
}

function getNewText(){
    return document.getElementById(newNoteTextId).value;
}

function getChangeNoteData(){
    
    let title = getChangeTitle();
    let text = getChangeText();

    return new Note(title, text);
}

function getChangeTitle(){
    return document.getElementById(changeNoteTitleId).value;
}

function getChangeText(){
    return document.getElementById(changeNoteTextId).value;
}

function clearInput(){
    document.getElementById(newNoteTitleId).value = "";
    document.getElementById(newNoteTextId).value = "";
}

function openModalWindow(command){
    document.getElementById(modalWindowId)
    .style.display = "block";

    if(command == 'new'){
        document.getElementById('new-note-wrapper')
        .style.display = 'block';
    }

    if(command == 'change'){
        document.getElementById('change-note-wrapper')
        .style.display = "block";
    }
    
}

function closeModalWindow(){
    if (blindFlag){
        blindFlag = false;
        return;
    }

    document.getElementById(modalWindowId)
    .style.display = "none";

    document.getElementById('new-note-wrapper')
    .style.display = 'none';

    document.getElementById('change-note-wrapper')
    .style.display = "none";
}

function blind(){
    blindFlag = true;
}

function deleteFlag(){
    deleteButtonFlag = true;
}



///////////////////////////////////////////////search logic

const searchField = document.getElementById('search');
const searchButton = document.getElementById('search-button');
const clearSearch = document.getElementById('clear-search-button');




function findNotes(){

    if(!searchField.value.trim()){
        searchField.value = '';
        return;
    }

    clearSearch.style.display = "block";
    
    let text = searchField.value;

    let targetId = getTarget(notesCollection, text);

    hideNotes(targetId);

}

function getTarget(mapCollection, string){

    let target = [];

    for (let elem of mapCollection.collection.keys()){
        
        let note = notesCollection.getById(elem);
        
        if( haveMatch(note.title, string) 
        || haveMatch(note.text, string)) {

            target.push(elem);
        }
    }
   
    return target;
}

function haveMatch(string, substr){

    return string.toLowerCase().indexOf(substr.toLowerCase()) >= 0;
}

function hideNotes(except) {

    for (let id of notesCollection.collection.keys()){

        if(except.indexOf(id) == -1){

            document.getElementById(id).style.display = 'none';
        } else {
            document.getElementById(id).style.display = 'block';
        }

    }

}

function showAll(){
    
    for (let id of notesCollection.collection.keys()){
        
        document.getElementById(id).style.display = 'block';
    }
    clearSearch.style.display = "none";

    searchField.value = '';
}