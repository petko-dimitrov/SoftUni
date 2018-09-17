function solve(map, forces) {
    let matrix = [];

    for (const line of map) {
        let row = line.split(' ').map(x => Number(x));
        matrix.push(row);
    }

    for (let line of forces) {
        let [force, num] = line.split(' ');
        num = Number(num);

        switch (force){
            case 'breeze':
                for (let i = 0; i < matrix[num].length; i++) {
                    matrix[num][i] -= 15;

                    if (matrix[num][i] < 0) {
                        matrix[num][i] = 0;
                    }
                }
                break;
            case 'gale':
                for (let i = 0; i < matrix.length; i++) {
                    matrix[i][num] -= 20;

                    if (matrix[i][num] < 0) {
                        matrix[i][num] = 0;
                    }
                }
                break;
            case 'smog':
                for (let i = 0; i < matrix.length; i++) {
                    for (let j = 0; j < matrix[i].length; j++) {
                        matrix[i][j] += num;
                    }
                }
                break;
            default:
                break;
        }
    }

    let polutedBlocks = [];

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (matrix[i][j] >= 50) {
                polutedBlocks.push(`[${i}-${j}]`);
            }
        }
    }

    if (polutedBlocks.length > 0) {
        console.log("Polluted areas: " + polutedBlocks.join(', '));
    } else {
        console.log('No polluted areas');
    }
}

solve([
        "5 7 72 14 4",
        "41 35 37 27 33",
        "23 16 27 42 12",
        "2 20 28 39 14",
        "16 34 31 10 24",
    ],
    ["breeze 1", "gale 2", "smog 25"]);