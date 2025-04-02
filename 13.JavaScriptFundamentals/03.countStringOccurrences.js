function occurs(text, word){

    let wordsList = text.split(" ");

    let count = 0;

    for (let element of wordsList) {

        if(element === word){

            count++;
        }
        
    }

    console.log(count);

}

occurs('This is a word and it also is a sentence','is');