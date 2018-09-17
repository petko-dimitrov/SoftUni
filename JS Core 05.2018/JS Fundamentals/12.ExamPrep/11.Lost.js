function solve(keyword, text) {
    let messageRegex = new RegExp(keyword + "(.*?)" + keyword, 'g');
    let message = messageRegex.exec(text)[1];
    let coordRegex = /(north|east)\D*(\d{2})[^,]*,\D*(\d{6})/gi;
    
    let match = coordRegex.exec(text);
    let northWhole;
    let northDecimal;
    let eastWhole;
    let eastDecimal;

    while (match) {
        if (match[1].toLowerCase() === 'north') {
            northWhole = match[2];
            northDecimal = match[3];
        } else {
            eastWhole = match[2];
            eastDecimal = match[3];
        }

        match = coordRegex.exec(text);
    }

    console.log(`${northWhole}.${northDecimal} N`);
    console.log(`${eastWhole}.${eastDecimal} E`);
    console.log(`Message: ${message}`);
}

solve('<>',
    'o u%&lu43t&^ftgv><nortH4276hrv756dcc,  jytbu64574655k <>ThE sanDwich is iN the refrIGErator<>yl i75evEAsTer23,lfwe 987324tlblu6b');