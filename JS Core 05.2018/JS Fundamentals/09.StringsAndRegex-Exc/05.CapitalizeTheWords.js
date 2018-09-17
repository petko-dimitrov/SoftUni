function capitalize(str) {
    str = str.toLowerCase();
    let words = str.split(' ');

    for (let i = 0; i < words.length; i++) {
        if (words[i].charCodeAt(0) > 96 && words[i].charCodeAt(0) < 123) {
            let current = words[i][0].toUpperCase();
            current += words[i].substr(1);
            words[i] = current;
        }
    }

    console.log(words.join(' '));
}

capitalize('Capitalize these words');

