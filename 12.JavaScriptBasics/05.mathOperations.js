function calculation(a, b, sign){

    let result;

switch(sign){
    case '+':
        result = a + b;
        break;
        case '-':
        result = a - b;
        break;
        case '*':
        result = a * b;
        break;
        case '/':
        result = a / b;
        break;
        case '%':
        result = a % b;
        break;
        case '**':
        result = a ** b;
        break;
}

console.log(result);

}

calculation(2, 3, '*');