"use strict";

function charRemover(text) {

    let setOfDuplicatLetters = getDuplicateLettersFromString(text);

    for (let char of setOfDuplicatLetters) {
        text = text.split(char).join("");
    }

    return text;
}

function isChar(char) {

    if (!char || char.length > 1) {
        return false;
    }

    char = char.toUpperCase();

    return (char >= "A" && char <= "Z")
        || (char >= "А" && char <= "Я")
        || (char == "Ё");
}

function textToArrayOfWords(text) {

    text = text.split("!").join("").split("?").join("")
        .split(".").join("").split(",").join("")
        .split(":").join("").split(";").join("");

    return text.split(" ");
}


function getDuplicateLettersFromString(text) {

    let wordArray = textToArrayOfWords(text);

    let duplicateLetters = new Set();

    for (let word of wordArray) {
        if (word) {
            if (word.length == new Set(word).size) {
                continue;
            } else {
                for (let char of getDuplicateLettersFromWord(word)) {
                    duplicateLetters.add(char);
                }
            }
        }
    }

    return duplicateLetters;

}

function getDuplicateLettersFromWord(word) {

    let duplicateLetters = new Set();

    for (let char in word) {
        if (word.indexOf(word[char]) != word.lastIndexOf(word[char])) {
            duplicateLetters.add(word[char]);
        }
    }

    return duplicateLetters;


}



let t = "У попа была собака";

let res = charRemover(t);
console.log(res);

