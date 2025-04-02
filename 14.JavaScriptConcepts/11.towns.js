function towns(input){

    for (const element of input) {

        let towns = [];

        let [town, latitude, longitude] = element.split(" | ");

        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);

        let currentTown = {
            town,
            latitude,
            longitude
        }

        towns.push(currentTown);

        for (const element of towns) {
            
            console.log(element);
        }
    
    }

}

towns(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']);
towns(['Plovdiv | 136.45 | 812.575']);