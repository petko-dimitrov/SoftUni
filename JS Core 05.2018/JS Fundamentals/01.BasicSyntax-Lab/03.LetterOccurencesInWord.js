function countOccurences(word, letter) {
    let counter = 0;

    for (let i = 0; i < word.length; i++) {
        if (word[i] == letter) {
            counter++;
        }
    }

    console.log(counter);
}

countOccurences('hello', 'l');