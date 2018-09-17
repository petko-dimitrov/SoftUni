function solve(num1, num2) {
    if (num1 === 0) {
        return num2;
    }
    if (num2 === 0) {
        return num1;
    }

    while (num1 && num2) {
        let temp = num1 % num2;
        num1 = num2;
        num2 = temp;

        if (num1 === 0) {
            return num2;
        }
        if (num2 === 0) {
            return num1;
        }
    }
}

console.log(solve(0, 105));