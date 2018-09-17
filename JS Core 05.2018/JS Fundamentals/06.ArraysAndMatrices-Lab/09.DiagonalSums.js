function solve(matrix) {
    let sumMain = 0;
    let sumSecondary = 0;

    for (let row = 0; row < matrix.length; row++) {
        sumMain += matrix[row][row];
        sumSecondary += matrix[row][matrix.length - 1 - row];
    }

    console.log(sumMain + ' ' + sumSecondary);
}

solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);