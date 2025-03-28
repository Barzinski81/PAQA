function reverse(n, input){

    let array = [...input];

    console.log(array.slice(0, n).reverse().join(" "));
}

reverse(3, [10, 20, 30, 40, 50]);