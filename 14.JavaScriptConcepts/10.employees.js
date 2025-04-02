function employee(arr){

    let employees = [];

    for (let element of arr) {
    
    let name = element;
    let number = element.length;

    let object = {
        name,
        number
    }

    employees.push(object);

   }

   employees.forEach(object => console.log(`Name: ${object.name} -- Personal Number: ${object.number}`))
}

employee([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ]);
employee([
    'Samuel Jackson',
    'Will Smith',
    'Bruce Willis',
    'Tom Holland'
    ]);