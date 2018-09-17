function solve(arr) {
    let towns = [];

    for (let i = 1; i < arr.length; i++) {
        let [empty, town, latitude, longitude] = arr[i].split(/\s*\|\s*/);
        let obj = {"Town": town, Latitude: +latitude, Longitude: +longitude};
        towns.push(obj);
    }

    console.log(JSON.stringify(towns));
}

solve(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']);