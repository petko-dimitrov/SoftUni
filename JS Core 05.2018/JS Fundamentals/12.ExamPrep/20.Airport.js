function solve(arr) {
    let planesInTown = [];
    let townsInfo = {};
    let townsPlanes = {};

    for (let line of arr) {
        let isValid = false;
        let [plane, town, passengers, action] = line.split(' ').filter(x => x !== '');
        passengers = Number(passengers);

        if (action === 'land' && planesInTown.indexOf(plane) < 0) {
            planesInTown.push(plane);
            isValid = true;
        } else if (action === 'depart' && planesInTown.indexOf(plane) >= 0) {
            planesInTown.splice(planesInTown.indexOf(plane), 1);
            isValid = true;
        }

        if (isValid) {
            if (!townsInfo.hasOwnProperty(town)) {
                townsInfo[town] = {};
                townsInfo[town]['departures'] = 0;
                townsInfo[town]['arrivals'] = 0;
                townsPlanes[town] = [];
                townsPlanes[town].push(plane);
            } else if (townsPlanes[town].indexOf(plane) < 0) {
                townsPlanes[town].push(plane);
            }

            if (action === 'land') {
                townsInfo[town]['arrivals'] += passengers;
            } else if (action === 'depart') {
                townsInfo[town]['departures'] += passengers;
            }
        }
    }

    planesInTown.sort((a, b) => a.localeCompare(b));
    console.log("Planes left:");
    for (let plane of planesInTown) {
        console.log(`- ${plane}`);
    }

    let sortedTowns = Object.keys(townsInfo).sort((a, b) => {
        if (townsInfo[b].arrivals === townsInfo[a].arrivals) {
            return a.localeCompare(b);
        } else {
            return townsInfo[b].arrivals - townsInfo[a].arrivals;
        }
    });

    for (let town of sortedTowns) {
        console.log(`${town}`);
        console.log(`Arrivals: ${townsInfo[town].arrivals}`);
        console.log(`Departures: ${townsInfo[town].departures}`);
        console.log('Planes:');
        townsPlanes[town].sort((a, b) => a.localeCompare(b));

        for (let plane of townsPlanes[town]) {
            console.log(`-- ${plane}`);
        }
    }
}

solve(["Boeing474 Madrid 300 land",
    "AirForceOne WashingtonDC 178 land",
    "Airbus London 265 depart",
    "ATR72 WashingtonDC 272 land",
    "ATR72 Madrid 135 depart"
]);