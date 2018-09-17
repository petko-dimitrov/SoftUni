function solve(matrix) {
    let biggest = Number.NEGATIVE_INFINITY;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (biggest < matrix[row][col]) {
                biggest = matrix[row][col];
            }
        }
    }

    console.log(biggest);
}

solve([[20, 50, 10],
    [8, 33, 145]]);