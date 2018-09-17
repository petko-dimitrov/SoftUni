function solve(base, increment) {
    let steps = 0;
    let stone = 0;
    let marble = 0;
    let lapis = 0;
    let gold = 0;

    for (let i = base; i > 2; i-=2) {
        steps++;

        if (steps % 5 === 0) {
            lapis += (4 * base - 4) * increment;
        } else {
            marble += (4 * base - 4) * increment;
        }

        stone += Math.pow(base - 2, 2) * increment;
        base -= 2;
    }

    steps++;
    gold += Math.ceil(base * base * increment);
    stone = Math.ceil(stone);
    marble = Math.ceil(marble);
    lapis = Math.ceil(lapis);

    console.log(`Stone required: ${stone}`);
    console.log(`Marble required: ${marble}`);
    console.log(`Lapis Lazuli required: ${lapis}`);
    console.log(`Gold required: ${gold}`);
    console.log(`Final pyramid height: ${Math.floor(steps * increment)}`);
}

solve(23, 0.5);