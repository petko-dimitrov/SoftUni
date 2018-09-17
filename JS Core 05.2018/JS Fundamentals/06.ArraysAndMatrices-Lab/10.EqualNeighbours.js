function solve(matrix) {
    let count = 0;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] === matrix[row][col+1]){
                count++;
            }

            if (row < matrix.length - 1 && matrix[row][col] === matrix[row+1][col]){
                count++;
            }
        }
    }

    console.log(count);
}

solve([['test', 'yes', 'yo', 'ho'],
    ['well', 'done', 'yo', '6'],
    ['not', 'done', 'yet', '5']]);