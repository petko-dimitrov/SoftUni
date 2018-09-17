function solve(arr) {
    let totalGold = 0;
    let specialized = ['Programming', 'Hardware maintenance', 'Cooking', 'Translating', 'Designing'];
    let average = ['Driving', 'Managing', 'Fishing', 'Gardening'];
    let clumsy = ['Singing', 'Accounting', 'Teaching', 'Exam-Making',
        'Acting', 'Writing', 'Lecturing', 'Modeling', 'Nursing'];
    let specializedCount = 0;
    let clumsyCount = 0;


    for (let entry of arr) {
        let [profession, gold] = entry.split(' : ');
        gold = Number(gold);

        if (specialized.indexOf(profession) >= 0) {
            if (gold < 200) {
                continue;
            }

            totalGold += gold * 0.8;
            specializedCount++;

            if (specializedCount % 2 === 0){
                totalGold += 200;
            }
        } else if (clumsy.indexOf(profession) >= 0) {
            clumsyCount++;

            if (clumsyCount % 2 === 0) {
                gold *= 0.95;
            } else if (clumsyCount % 3 === 0) {
                gold *= 0.9;
            }

            totalGold += gold;
        } else {
            totalGold += gold;
        }
    }

    console.log(`Final sum: ${totalGold.toFixed(2)}`);
    if (totalGold >= 1000) {
        console.log(`Mariyka earned ${(totalGold - 1000).toFixed(2)} gold more.`);
    } else {
        console.log(`Mariyka need to earn ${(1000 - totalGold).toFixed(2)} gold more to continue in the next task.`);
    }
}

solve(["Programming : 500", "Driving : 243.55", "Acting : 200", "Singing : 100",
    "Cooking : 199", "Hardware maintenance : 800", "Gardening : 700", "Programming : 500"]);