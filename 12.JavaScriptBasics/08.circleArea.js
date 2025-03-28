function area(input){

    let type = typeof (input);

    if (type === 'number'){
        console.log((Math.PI * input * input).toFixed(2));
    }else{
        console.log(`We can not calculate the circle area, because we received a ${type}.`);
    }
}

area ('test');