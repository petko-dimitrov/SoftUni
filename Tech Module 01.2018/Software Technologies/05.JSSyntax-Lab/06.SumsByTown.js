function sumsByTown(arr) {
    let pairs = arr.map(JSON.parse);
    let sums = {};

    for (let obj of pairs) {
        if(obj.town in sums){
            sums[obj.town] += obj.income;
        }
        else{
            sums[obj.town] = obj.income;
        }
    }

    let towns = Object.keys(sums).sort();

    for(let town of towns){
        console.log(`${town} -> ${sums[town]}`);
    }
}