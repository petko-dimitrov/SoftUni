function calculator(num1, num2, operator) {
    let add = function (num1, num2) {
        return num1 + num2;
    };

    let subtract = function (num1, num2) {
        return num1 - num2;
    };

    let multiply = function (num1, num2) {
        return num1 * num2;
    };

    let divide = function (num1, num2) {
        return num1 / num2;
    };

    switch (operator) {
        case '+':
            console.log(add(num1, num2));
            break;
        case '-':
            console.log(subtract(num1, num2));
            break;
        case '*':
            console.log(multiply(num1, num2));
            break;
        case '/':
            console.log(divide(num1, num2));
            break;
        default:
            break;
    }
}

calculator(2, 4, '+');