function person(firstName, lastName, age){

    let person = {};

    person.firstName = firstName;
    person.lastName = lastName;
    person.age = age;

    return person;

}

console.log(person("Peter", "Pan","20"));