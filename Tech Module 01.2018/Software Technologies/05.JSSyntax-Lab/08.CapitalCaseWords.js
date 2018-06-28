function extractCapitalCase(arr) {
    let text = arr.join(',');
    let words = text.split(/\W+/);
    let validWords = words.filter(x => x.length > 0);
    let upperWords = validWords.filter(checkIfIsUpper);
    console.log(upperWords.join(', '));

    function checkIfIsUpper(word) {
        return word === word.toUpperCase();
    }
}