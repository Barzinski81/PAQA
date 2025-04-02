function leap(n){

    if((n % 4 === 0 && n % 100 !== 0) || n % 400 === 0){

        console.log("yes");
    
    }else{

        console.log("no");
    }

}

leap(1984);
leap(2003);
leap(4);