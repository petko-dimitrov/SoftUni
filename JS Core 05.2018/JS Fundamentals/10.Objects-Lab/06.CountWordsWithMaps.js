function solve(arr) {
    let words = arr[0].split(/\W+/).filter(x => x !== '').map(x => x.toLowerCase());
    let map = new Map();

    for (let word of words) {
        if (!map.has(word)) {
            map.set(word, 1);
        } else {
            map.set(word, map.get(word) + 1);
        }
    }

    let sorted = Array.from(map.keys()).sort();

    for (let word of sorted) {
        console.log(`'${word}' -> ${map.get(word)} times`);
    }
}

solve(['Far too slow, you\'re far too slow.\n']);