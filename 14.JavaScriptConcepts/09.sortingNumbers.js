function sorting(input){

    let arr = input.map((el) => Number(el));

    let result = [];

    arr.sort((a,b) => a - b);

    let length = arr.length -1;

    for (let index = 0; index <= length / 2; index++) {
       
        if(arr.length % 2  !== 0){
            if(index === length / 2){
                result.push(arr[index]);
            }else{
                result.push(arr[index]);
                result.push(arr[length - index]);
            }
        }else{
            result.push(arr[index]);
            result.push(arr[length - index]);
        }
        
    }

    return result.join("\n");

}

console.log(sorting([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));