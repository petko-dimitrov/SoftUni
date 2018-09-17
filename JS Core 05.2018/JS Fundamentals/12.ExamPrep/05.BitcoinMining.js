function solve(arr) {
    let money = 0;
    let bitcoins = 0;
    let firstBitcoinDay = 0;
    let bougtBitcoin = false;

    for (let i = 0; i < arr.length; i++) {
        let gold = arr[i];

        if ((i + 1) % 3 === 0) {
            gold *= 0.7;
        }
        money += gold * 67.51;

        if (money >= 11949.16) {
            if (!bougtBitcoin) {
                bougtBitcoin = true;
                firstBitcoinDay = i + 1;
            }
            bitcoins += Math.floor(money / 11949.16);
            money = money % 11949.16;
        }
    }

    console.log(`Bought bitcoins: ${bitcoins}`);
    if (bougtBitcoin) {
        console.log(`Day of the first purchased bitcoin: ${firstBitcoinDay}`);
    }
    console.log(`Left money: ${money.toFixed(2)} lv.`);
}

solve([100, 200, 300]);