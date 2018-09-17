function solve(arr) {
    let wordPattern = /\b[a-zA-Z0-9_]+\b/g;
    let uniqueWords = new Set();

    for (let line of arr) {
        let matches = line.match(wordPattern);
        matches.forEach(x => uniqueWords.add(x.toLowerCase()));
    }

    console.log(Array.from(uniqueWords).join(', '));
}

solve(['Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
    'Pellentesque quis hendrerit dui. ']);