function printBill(arr) {
    let products = arr.filter((x, i) => i % 2 === 0);
    let sum = arr.filter((x, i) => i % 2 !== 0)
        .map(Number)
        .reduce((a, b) => a + b);

    console.log(`You purchased ${products.join(', ')} for a total sum of ${sum}`);
}

printBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80', 'Lasagna', '5.69']);