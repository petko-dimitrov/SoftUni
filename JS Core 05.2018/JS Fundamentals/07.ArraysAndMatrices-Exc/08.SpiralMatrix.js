function drawSpiralMatrix(rows, cols) {
    let totalCount = rows * cols;
    let counter = 1;
    let matrix = [];

    for (let i = 0; i < rows; i++) {
        matrix[i] = new Array(cols);
    }

    while (counter <= totalCount) {
        //right
        for (let col = 0; col < cols; col++) {
            if (matrix[0][col] === undefined){
                matrix[0][col] = counter;
                counter++;
            }
        }

        //down
        for (let row = 1; row < rows; row++) {
            if (matrix[row][cols-1] === undefined){
                matrix[row][cols - 1] = counter;
                counter++;
            }
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}

drawSpiralMatrix(5, 5);