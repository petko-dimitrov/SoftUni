function calculateSumAndVAT(numbers) {
    let sum = 0;

    for (let number of numbers) {
        sum += number;
    }

    let vat = sum * 0.2;
    let totalSum = sum * 1.2;

    console.log("sum = " + sum);
    console.log("VAT = " + vat);
    console.log("total = " + totalSum);
}

calculateSumAndVAT([1.20, 2.60, 3.50]);