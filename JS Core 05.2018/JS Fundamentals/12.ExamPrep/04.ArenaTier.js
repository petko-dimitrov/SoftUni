function solve(arr) {
    let gladiators = {};
    let gladiatorsTotalSkills = {};

    for (let i = 0; i < arr.length - 1; i++) {
        if (arr[i].includes('->')) {
            let [name, technique, skill] = arr[i].split(' -> ').filter(x => x !== '');
            skill = Number(skill);

            if (!gladiators.hasOwnProperty(name)) {
                gladiators[name] = {};
                gladiators[name][technique] = skill;
                gladiatorsTotalSkills[name] = skill;
            } else if (!gladiators[name].hasOwnProperty(technique)) {
                gladiators[name][technique] = skill;
                gladiatorsTotalSkills[name] += skill;
            } else if (gladiators[name][technique] < skill) {
                gladiatorsTotalSkills[name] += skill - gladiators[name][technique];
                gladiators[name][technique] = skill;
            }
        } else {
            let [firstGlad, secondGlad] = arr[i].split(' vs ').filter(x => x !== '');

            if (gladiators.hasOwnProperty(firstGlad) && gladiators.hasOwnProperty(secondGlad)) {
                for (let tech in gladiators[firstGlad]) {
                    let g1Score = gladiators[firstGlad][tech];
                    let g2Score = gladiators[secondGlad][tech];

                    if (g1Score && g2Score) {
                        if (gladiatorsTotalSkills[firstGlad] > gladiatorsTotalSkills[secondGlad]) {
                            delete gladiators[secondGlad];
                            delete gladiatorsTotalSkills[secondGlad];
                        } else {
                            delete gladiators[firstGlad];
                            delete gladiatorsTotalSkills[firstGlad];
                        }

                        break;
                    }
                }
            }
        }
    }

    let sortedGlads = Object.keys(gladiatorsTotalSkills).sort((a, b) => {
        if (gladiatorsTotalSkills[a] === gladiatorsTotalSkills[b]) {
            return a.localeCompare(b);
        } else {
            return gladiatorsTotalSkills[b] - gladiatorsTotalSkills[a];
        }
    });

    for (let glad of sortedGlads) {
        console.log(`${glad}: ${gladiatorsTotalSkills[glad]} skill`);

        let orderedTechniques = Object.keys(gladiators[glad]).sort((a, b) => {
            if (gladiators[glad][a] === gladiators[glad][b]) {
                return a.localeCompare(b);
            } else {
                return gladiators[glad][b] - gladiators[glad][a];
            }
        });

        for (let tech of orderedTechniques) {
            console.log(`- ${tech} <!> ${gladiators[glad][tech]}`);
        }
    }
}

solve(['Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Pesho vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Gosho',
    'Ave Cesar']);