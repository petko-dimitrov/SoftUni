function solve() {
    let prevNumber = 0;
    let number = 1;

    return function () {
        let temp = number + prevNumber;
        prevNumber = number;
        number = temp;
        return prevNumber;
    }
}

let fib = solve();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());