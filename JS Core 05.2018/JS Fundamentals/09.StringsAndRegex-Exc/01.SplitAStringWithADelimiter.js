function splitStr(str, delimiter) {
    let words = str.split(delimiter);
    console.log(words.join('\n'));
}

splitStr('One-Two-Three-Four-Five', '-');