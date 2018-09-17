function solve(arr) {
    let numbers = [];

    for (let element of arr) {
        if (typeof element === "number") {
            numbers.push(element);
        } else if (numbers.length > 1) {
            let result = 0;
            let num2 = numbers.pop();
            let num1 = numbers.pop();
            switch (element) {
                case '+':
                    result = num1 + num2;
                    numbers.push(result);
                    break;
                case '-':
                    result = num1 - num2;
                    numbers.push(result);
                    break;
                case '*':
                    result = num1 * num2;
                    numbers.push(result);
                    break;
                case '/':
                    result = num1 / num2;
                    numbers.push(result);
                    break;
                default:
                    break;
            }
        } else {
            console.log('Error: not enough operands!');
            return;
        }
    }

    if (numbers.length === 1) {
        console.log(numbers[0]);
    } else {
        console.log('Error: too many operands!');
    }
}

solve([5,
    3,
    4,
    '*',
    '-']);