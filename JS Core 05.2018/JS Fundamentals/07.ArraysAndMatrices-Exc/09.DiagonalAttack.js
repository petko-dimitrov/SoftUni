function solve(arr) {
    let matrix = [];

    for (let i = 0; i < arr.length; i++) {
        matrix[i] = [];
    }

    for (let i = 0; i < arr.length; i++) {
        matrix[i] = arr[i].split(' ').map(Number);
    }

    // for (let row = 0; row < matrix.length; row++) {
    //     for (let col = 0; col < matrix[row].length; col++) {
    //         matrix[row][col] = Number(matrix[row][col]);
    //     }
    // }

    let leftDiagonalSum = 0;
    let rightDiagonalSum = 0;

    for (let i = 0; i < matrix.length; i++) {
        leftDiagonalSum += matrix[i][i];
    }

    for (let i = 0; i < matrix.length; i++) {
        rightDiagonalSum += matrix[i][matrix[i].length - 1 - i];
    }

    if (leftDiagonalSum === rightDiagonalSum) {
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                if (row !== col && col !== matrix[row].length - 1 - row){
                    matrix[row][col] = leftDiagonalSum;
                }
            }
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}

solve(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']);