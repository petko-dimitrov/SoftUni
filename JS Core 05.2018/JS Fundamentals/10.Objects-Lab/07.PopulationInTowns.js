function solve(arr) {
    let towns = new Map();

    for (let line of arr) {
        let [town, population] = line.split(' <-> ');
        if (!towns.has(town)) {
            towns.set(town, +population);
        } else {
            towns.set(town, towns.get(town) + Number(population));
        }
    }

    for (let [key, value] of towns) {
        console.log(`${key} : ${value}`);
    }
}

solve(['Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000']);