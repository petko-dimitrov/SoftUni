function solve(num1) {
    let sum = num1;

    function add(num2) {
        sum += num2;
        return add;
    }

    add.toString = function () {
        return sum;
    };

    return add;
}

let add = solve(0);
console.log(add(1)(6)(-3));
