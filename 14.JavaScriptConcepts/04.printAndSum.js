function sum(arr){

    let a = Number(arr[0]);
    let b = Number(arr[1]);

    let numbers = [];
    // let sum = 0;

    for (let index = a; index <= b; index++) {
       
        // sum += index;
        numbers.push(index);

    }

    console.log(numbers.join(" "));
    // console.log (`Sum: ${sum}`);
    console.log (`Sum: ${eval(numbers.join("+"))}`);
}

sum([5, 10]);
sum([0, 26]);
sum([50, 60]);