function extract(text) {
    let start = text.indexOf('(');
    let end = text.indexOf(')', start);
    let result = [];


    while (start > - 1 && end > -1) {
        result.push(text.substring(start + 1, end));
        start = text.indexOf('(', end);
        end = text.indexOf(')', start);
    }

    console.log(result.join(', '));
}

extract('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');