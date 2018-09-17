function printFigure(n) {
    let cols = 2 * n - 1;

    if (n % 2 === 0) {
        n--;
    }

    let symbol1 = '';
    let symbol2 = '';

    for (let row = 1; row <= n; row++) {
        if (row === 1 || row === Math.round(n / 2) || row === n) {
            symbol1 = '+';
            symbol2 = '-';
        } else {
            symbol1 = '|';
            symbol2 = ' ';
        }

        let currentRow = '';

        for (let col = 1; col <= cols; col++) {
            if (col === 1 || col === Math.round(cols / 2) || col === cols) {
                currentRow += symbol1;
            } else {
                currentRow += symbol2;
            }
        }

        console.log(currentRow);
    }
}

printFigure(4);