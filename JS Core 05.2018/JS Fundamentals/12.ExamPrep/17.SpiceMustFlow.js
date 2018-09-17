function solve(startYield) {
    startYield = Number(startYield);
    let days = 0;
    let spice = 0;

    while (startYield >= 100) {
        days++;
        spice += startYield;
        spice = eatSpice(spice);
        startYield -= 10;
    }

    spice = eatSpice(spice);
    console.log(days + '\n' + spice);

    function eatSpice(spice) {
        if (spice >= 26) {
            spice -= 26;
        } else {
            spice = 0;
        }

        return spice;
    }
}

solve('111');

