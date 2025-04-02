function sum(n){

let sum = 0;

while(n > 0){

    let lastDigit = n % 10;
    sum += lastDigit;
    n = Math.floor (n / 10);
}

console.log(sum);

}

sum(245678);
sum(97561);
sum(543);