function repeat(string, n){

    let result = "";
    
    for ( i = 0; i < n; i++){

        result += string;
    }

    return result;
}

console.log(repeat("abc", 3));