function orders(name, n){

let price = 1.00;

switch(name){
    case 'coffee': price = 1.50; break;
    case 'coke': price = 1.40; break;
    case 'snacks': price = 2; break;
}

console.log((price * n).toFixed(2));

}

orders("water", 2);