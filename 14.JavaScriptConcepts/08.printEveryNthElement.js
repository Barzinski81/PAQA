function rotate(arr){

    let strArr = arr.filter((el) => el !== '')
    let step = Number(arr[strArr.length - 1])
    
    let result = [];
    
        for(let i = 0; i < strArr.length - 1; i+=step){

            result.push(strArr[i])
        }
    
    console.log(result.join('\n'))

}

rotate(['5', 
    '20', 
    '31', 
    '4', 
    '20'], 
    2
    );
rotate(['dsa',
    'asd', 
    'test', 
    'tset'], 
    2
    );
rotate(['1', 
    '2',
    '3', 
    '4', 
    '5'], 
    6
    );