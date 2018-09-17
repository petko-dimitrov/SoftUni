function solve(text, word) {
    let regex = new RegExp("\\b" + word + "\\b", "gi");
    let count = 0;
    let match;

    while (match = regex.exec(text)) {
        count++;
    }

    console.log(count);
}

solve('There was one. Therefore I bought it. I wouldn�t buy it otherwise.',
    'there');