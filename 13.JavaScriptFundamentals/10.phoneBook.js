function phoneBook(array){

    let phoneBook = {} ;

    for (let element of array) {
         
        let [name, number] = element.split(" ");
        phoneBook[name] = number;
    }

    for (let key in phoneBook) {

        console.log(`${key} -> ${phoneBook[key]}`)
    }

}

phoneBook(['Tim 0834212554',
    'Peter 0877547887',
    'Bill 0896543112',
    'Tim 0876566344']
   );