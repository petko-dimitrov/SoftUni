function checkIfMagical(matrix) {
    let rowSum = matrix[0].reduce((a, b) => a + b);
    let colSum = 0;

    for (let row = 0; row < matrix.length; row++) {
        colSum += matrix[row][0];
    }

    let isMagic = true;

    for (let row = 1; row < matrix.length; row++) {
        let currentRowSum = matrix[row].reduce((a, b) => a + b);

        if (currentRowSum !== rowSum) {
            isMagic = false;
            console.log(isMagic);
            return;
        }
    }

    for (let col = 1; col < matrix.length; col++) {
        let currentColSum = 0;

        for (let row = 0; row < matrix.length; row++) {
            currentColSum += matrix[row][col];
        }

        if (currentColSum !== colSum) {
            isMagic = false;
            console.log(isMagic);
            return;
        }
    }

    console.log(isMagic);
}

checkIfMagical([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]);