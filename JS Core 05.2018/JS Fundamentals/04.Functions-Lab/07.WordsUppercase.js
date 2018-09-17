function convertToUpper(text) {
    let words = text.split(/\W+/);
    words = words.filter(w => w !== '').map(w => w.toUpperCase());

    return words.join(', ');
}

console.log(convertToUpper('Hi, how are you?'));