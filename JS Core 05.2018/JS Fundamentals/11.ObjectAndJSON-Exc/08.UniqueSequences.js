function solve(arr) {
    let uniqueArrays = [];
    let sortedArrays = [];

    for (const line of arr) {
        let currentArr = JSON.parse(line);
        let sortedArr = currentArr.sort((a, b) => b - a);
        let comparisons = [];

        for (let arr of sortedArrays) {
            let isUnique = false;

            if (sortedArr.length !== arr.length) {
                isUnique = true;
                comparisons.push(isUnique);
                continue;
            }

            for (let i = 0; i < arr.length; i++) {
                if (arr[i] !== sortedArr[i]) {
                    isUnique = true;
                    comparisons.push(isUnique);
                    break;
                }
            }
            comparisons.push(isUnique);
        }

        if (!comparisons.includes(false)) {
            uniqueArrays.push(sortedArr);
        }
        sortedArrays.push(sortedArr);
    }

    let sorted = uniqueArrays.sort((a, b) => a.length - b.length);

    for (let arr of sorted) {
        console.log(`[${arr.join(', ')}]`);
    }
}

solve(['[-3, -2, -1, 0, 1, 2, 3, 4]',
    '[10, 1, -17, 0, 2, 13]',
    '[4, -3, 3, -2, 2, -1, 1, 0]']);