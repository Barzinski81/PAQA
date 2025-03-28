function sum(input){
    let first = parseFloat(input[0]);
    let last = parseFloat(input[input.length - 1]);

    console.log(first + last);
}

sum([20, 30, 40]);