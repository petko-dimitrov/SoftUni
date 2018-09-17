function solve(lostFights, helmetPr, swordPr, shieldPr, armorPr) {
    let expenses = 0;

    for (let i = 1; i <= lostFights; i++) {
        if (i % 2 === 0) {
            expenses += helmetPr;
        }
        if (i % 3 === 0) {
            expenses += swordPr;
        }
        if (i % 6 === 0) {
            expenses += shieldPr;
        }
        if (i % 12 === 0) {
            expenses += armorPr;
        }
    }

    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`);
}

solve(7, 2, 3, 4, 5);