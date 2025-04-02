function grade(grade){
   
   let text = "";

    if (grade < 3.00){
        console.log("Fail (2)");
    }else if(grade >= 3.00 && grade < 3.50){
        text = "Poor"  
    }else if(grade >= 3.50 && grade < 4.50){
        text = "Good";
    }else if(grade >= 4.50 && grade < 5.50){
        text = "Very good";
    }else if(grade >= 5.50){
        text = "Excellent";
    }

    if (grade >= 3.00){

        console.log(`${text} (${grade.toFixed(2)})`)
    }

}

grade(4.70);

