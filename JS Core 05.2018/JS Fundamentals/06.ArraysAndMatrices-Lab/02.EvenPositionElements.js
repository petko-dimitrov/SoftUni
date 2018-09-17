function printAtEven(arr) {
    console.log(arr.filter((x, i) => i % 2 === 0).join(' '));
}

printAtEven(['20', '30', '40']);