function solve(primary, secondary, overlay, start) {
    for (let coordinates of overlay) {
        let [rowCoord, colCoord] = coordinates;

        for (let row = 0; row < secondary.length; row++) {
            for (let col = 0; col < secondary[row].length; col++) {
                if (row + rowCoord < primary.length && col + colCoord < primary[0].length) {
                    let primaryValue = primary[row + rowCoord][col + colCoord];
                    let secondaryValue = secondary[row][col];

                    if (primaryValue === 1 && secondaryValue === 1) {
                        primary[row + rowCoord][col + colCoord] = 0;
                    } else if (primaryValue === 0 && secondaryValue === 1) {
                        primary[row + rowCoord][col + colCoord] = 1;
                    }
                }
            }
        }
    }

    let steps = 1;
    let row = start[0];
    let col = start[1];

    while (true) {
        primary[row][col] = 2;

        if (primary[row+1][col] === 0 && row + 1 < primary.length){   //down
            steps++;
            row++;
            if (row === primary.length - 1) {
                console.log(steps);
                console.log('Bottom');
                break;
            }
        } else if (primary[row-1][col] === 0 && row - 1 > 0) { //up
            steps++;
            row--;
            if (row === 0) {
                console.log(steps);
                console.log('Top');
                break;
            }
        } else if (primary[row][col-1] === 0 && col - 1 > 0) { //left
            steps++;
            col--;
            if (col === 0) {
                console.log(steps);
                console.log('Left');
                break;
            }
        } else if (primary[row][col+1] === 0 && col + 1 < primary[row].length) { //right
            steps++;
            col++;
            if (col === primary[row].length - 1) {
                console.log(steps);
                console.log('Right');
                break;
            }
        } else {
            console.log(steps);
            let quadrant = 0;
            if (row <  primary.length / 2 && col < primary[0].length / 2) {
                quadrant = 2;
            } else if (row <  primary.length / 2 && col >= primary[0].length / 2) {
                quadrant = 1;
            } else if (row >=  primary.length / 2 && col >= primary[0].length / 2) {
                quadrant = 4;
            } else {
                quadrant = 3;
            }
            console.log(`Dead end ${quadrant}`);
            break;
        }
    }
}

solve([[1, 1, 0, 1, 1, 1, 1, 0],
        [0, 1, 1, 1, 0, 0, 0, 1],
        [1, 0, 0, 1, 0, 0, 0, 1],
        [0, 0, 0, 1, 1, 0, 0, 1],
        [1, 0, 0, 1, 1, 1, 1, 1],
        [1, 0, 1, 1, 0, 1, 0, 0]],
    [[0, 1, 1],
        [0, 1, 0],
        [1, 1, 0]],
    [[1, 1],
        [2, 3],
        [5, 3]],
    [0, 2]);