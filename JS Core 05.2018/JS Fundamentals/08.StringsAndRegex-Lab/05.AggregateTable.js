function aggregate(arr) {
    let towns = [];
    let totalIncome = 0;

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split('|');
        towns.push(tokens[1].trim());
        totalIncome += Number(tokens[2].trim());
    }

    console.log(towns.join(', '));
    console.log(totalIncome);
}

aggregate(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']);