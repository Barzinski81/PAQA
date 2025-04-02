function censor(text, word){

let result = text.replace(word, "*".repeat(word.length));

while (result.includes(word)){

    result = result.replace(word, "*".repeat(word.length));
}

console.log(result);

}

censor('A small sentence with some words', 'small');