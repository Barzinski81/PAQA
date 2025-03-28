function theatre(day, age){

    let price;

switch(true){
    case age >= 0 && age <= 18:
        if(day === "Weekday"){
            price = "12$";
        }else if(day === "Weekend"){
            price = "15$";
        }else if (day === "Holiday"){
            price = "5$";
        }
        break;
    case age > 18 && age <= 64:
        if(day === "Weekday"){
            price = "18$";
        }else if(day === "Weekend"){
            price = "20$";
        }else if (day === "Holiday"){
            price = "12$";
        }
        break;
    case age > 64 && age <= 122:
        if(day === "Weekday"){
            price = "12$";
        }else if(day === "Weekend"){
            price = "15$";
        }else if (day === "Holiday"){
            price = "10$";
        }
        break;
        default:
            price = "Error!";
            break;  
}

console.log(price);

}

theatre("Holiday", 52);