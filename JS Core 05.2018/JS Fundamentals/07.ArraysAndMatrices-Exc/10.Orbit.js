function solve(arr) {
    let [width, height, x, y] = arr;

    let matrix = [];
    for (let i = 0; i < height; i++) {
        matrix[i] = new Array(width);
    }

    matrix[x][y] = 1;
    let counter = 2;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            matrix[row][col] = row - x + 1 + col - y;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}

solve([4, 4, 0, 0]);