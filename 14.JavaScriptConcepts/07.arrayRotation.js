function array(arr, rotations){

    for (let index = 0; index < rotations; index++) {
    
        let element = arr.shift();
        arr.push(element);

    }

    console.log(arr.join(" "));
}

array([51, 47, 32, 61, 21], 2);
array([32, 21, 61, 1], 4);
array([2, 4, 15, 31], 5);