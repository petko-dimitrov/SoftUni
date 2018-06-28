function setValues(arr) {
    let arrLength = Number(arr[0]);
    let numbers = [];

    for (let i = 0; i < arrLength; i++) {
        numbers[i] = 0;
    }

    for (let i = 1; i < arr.length; i++) {
        let values = readLine(arr[i]);
        let index = values[0];
        let value = values[1];
        numbers[index] = value;
    }

    for (let num of numbers) {
        console.log(num);
    }

    function readLine(line) {
        let values = line.split(" - ").map(Number);
        return values;
    }
}