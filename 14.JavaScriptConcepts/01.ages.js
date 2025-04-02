function age(arr){

    let age = arr[0];

    let text ="";

    if (age < 0){
        text = "out of bounds";
    }else if(age >= 0 && age <= 2){
        text = "baby";
    }else if(age >= 3 && age <= 13){
        text = "child";
    }else if(age >= 14 && age <= 19){
        text = "teenager";
    }else if(age >= 20 && age <= 65){
        text = "adult";
    }else if(age >= 66){
        text = "elder";
    }

    console.log(text);

}

age(20);
age(1);
age(100);
age(-1);