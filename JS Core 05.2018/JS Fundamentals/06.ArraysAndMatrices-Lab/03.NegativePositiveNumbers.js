function solve(arr) {
    let newArr = [];
    
    for (let element of arr) {
        if (element < 0) {
            newArr.unshift(element)
        } else {
            newArr.push(element);
        }
    }

    for (let newArrElement of newArr) {
        console.log(newArrElement);
    }
}

solve([7, -2, 8, 9]);