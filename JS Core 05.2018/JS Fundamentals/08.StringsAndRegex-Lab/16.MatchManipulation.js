function solve(bill) {
    let regex = /(-?[1-9]+)\s*\*\s*(-?[0-9]\.?[0-9]+)/g;

    bill = bill.replace(regex, (all, num1, num2) => Number(num1 * num2));

    console.log(bill);
}

solve('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).');

