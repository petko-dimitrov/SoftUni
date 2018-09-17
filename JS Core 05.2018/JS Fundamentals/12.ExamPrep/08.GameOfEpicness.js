function solve(arr, battles) {
    let kingdoms = {};
    let kingdomsWins = {};

    for (line of arr) {
        let kingdom = line.kingdom;
        let general = line.general;
        let army = line.army;

        if (!kingdoms.hasOwnProperty(kingdom)) {
            kingdoms[kingdom] = {};
            kingdoms[kingdom][general] = {};
            kingdoms[kingdom][general]['army'] = army;
            kingdoms[kingdom][general]['wins'] = 0;
            kingdoms[kingdom][general]['losses'] = 0;
            kingdomsWins[kingdom] = [0, 0];

        } else if (!kingdoms[kingdom].hasOwnProperty(general)) {
            kingdoms[kingdom][general] = {};
            kingdoms[kingdom][general]['army'] = army;
            kingdoms[kingdom][general]['wins'] = 0;
            kingdoms[kingdom][general]['losses'] = 0;
        } else {
            kingdoms[kingdom][general]['army'] += army;
        }
    }

    for (let battle of battles) {
        let [attKingdom, attGeneral, defKingdom, defGeneral] = battle;

        if (kingdoms[attKingdom] !== kingdoms[defKingdom]) {
            if (kingdoms[attKingdom][attGeneral]['army'] > kingdoms[defKingdom][defGeneral]['army']) {
                kingdoms[attKingdom][attGeneral]['army'] = Math.floor(1.1 * kingdoms[attKingdom][attGeneral]['army']);
                kingdoms[defKingdom][defGeneral]['army'] = Math.floor(0.9 * kingdoms[defKingdom][defGeneral]['army']);
                kingdoms[attKingdom][attGeneral]['wins']++;
                kingdoms[defKingdom][defGeneral]['losses']++;
                kingdomsWins[attKingdom][0]++;
                kingdomsWins[defKingdom][1]++;
            } else if (kingdoms[attKingdom][attGeneral]['army'] < kingdoms[defKingdom][defGeneral]['army']) {
                kingdoms[attKingdom][attGeneral]['army'] = Math.floor(0.9 * kingdoms[attKingdom][attGeneral]['army']);
                kingdoms[defKingdom][defGeneral]['army'] = Math.floor(1.1 * kingdoms[defKingdom][defGeneral]['army']);
                kingdoms[attKingdom][attGeneral]['losses']++;
                kingdoms[defKingdom][defGeneral]['wins']++;
                kingdomsWins[attKingdom][1]++;
                kingdomsWins[defKingdom][0]++;
            }
        }
    }

    let sortedKingdoms = Object.keys(kingdomsWins).sort((a, b) => {
        if (kingdomsWins[a][0] === kingdomsWins[b][0]) {
            if (kingdomsWins[a][1] === kingdomsWins[b][1]) {
                a.localeCompare(b);
            } else {
                return kingdomsWins[a][1] - kingdomsWins[b][1];
            }
        } else {
            return kingdomsWins[b][0] - kingdomsWins[a][0];
        }
    });

    let winner = sortedKingdoms[0];
    console.log(`Winner: ${winner}`);

    let sortedGenerals = Object.keys(kingdoms[winner]).sort((a, b) => {
        return kingdoms[winner][b]['army'] - kingdoms[winner][a]['army'];
    });

    for (let gen of sortedGenerals) {
        console.log(`/\\general: ${gen}`);
        console.log(`---army: ${kingdoms[winner][gen]['army']}`);
        console.log(`---wins: ${kingdoms[winner][gen]['wins']}`);
        console.log(`---losses: ${kingdoms[winner][gen]['losses']}`);
    }
}

solve([ { kingdom: "Maiden Way", general: "Merek", army: 5000 },
        { kingdom: "Stonegate", general: "Ulric", army: 4900 },
        { kingdom: "Stonegate", general: "Doran", army: 70000 },
        { kingdom: "YorkenShire", general: "Quinn", army: 0 },
        { kingdom: "YorkenShire", general: "Quinn", army: 2000 },
        { kingdom: "YorkenShire", general: "Hui", army: 10000 }],
    [  ]);