function solve(arr) {
    let processor = (function() {
        let text = '';

        return {
            append: (newText) => text += newText,
            removeStart: (chars) => text = text.substring(chars),
            removeEnd: (chars) => text = text.substring(0, text.length - chars),
            print: () => console.log(text)
        }
    }());

    for (const line of arr) {
        let [command, value] = line.split(' ');
        processor[command](value);
    }
}

solve(['append hello',
    'append again',
    'removeStart 3',
    'removeEnd 4',
    'print']);