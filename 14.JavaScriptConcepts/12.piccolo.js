function parking(input){

    let parking = {};

    for (const element of input) {
        
        let [direction, number] = element.split(", ");

        if (direction === "IN"){
            parking[number] = number;
        }else if(direction === "OUT"){
            delete parking[number];
        }
    }

    let sorted = Object.values(parking).sort((a, b) => a.localeCompare(b))

    if(sorted.length === 0){

        console.log("Parking Lot is Empty");
    }else{

        for (const car of sorted) {
            
            console.log(car);
        }
    }

}

parking(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']);
parking(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA']);