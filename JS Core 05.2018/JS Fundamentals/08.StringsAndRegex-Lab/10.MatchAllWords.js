function matchAllWords(str) {
    let words = str.match(/\w+/g);
    console.log(words.join('|'));
}

matchAllWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');
