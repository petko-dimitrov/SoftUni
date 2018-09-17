function solve(arr) {
    let countries = {};

    for (let line of arr) {
        let [country, town, cost] = line.split(' > ');
        cost = Number(cost);
        let firstLetter = town.slice(0, 1).toUpperCase();
        town = firstLetter + town.slice(1);

        if (!countries.hasOwnProperty(country)) {
            countries[country] = {};
            countries[country][town] = cost;
        } else if (!countries[country].hasOwnProperty(town)) {
            countries[country][town] = cost;
        } else if (countries[country][town] > cost) {
            countries[country][town] = cost;
        }
    }

    let sortedCountries = Object.keys(countries).sort((a, b) => {
        return a.localeCompare(b);
    });

    let result = '';

    for (let sortedCountry of sortedCountries) {
        result += `${sortedCountry} -> `;
        let sortedTowns = Object.keys(countries[sortedCountry]).sort((a, b) => {
            return countries[sortedCountry][a] - countries[sortedCountry][b];
        });

        for (let sortedTown of sortedTowns) {
           result += `${sortedTown} -> ${countries[sortedCountry][sortedTown]} `;
        }

        result += '\n';
    }

    console.log(result);
}

solve(["Bulgaria > Sofia > 500",
    "Bulgaria > Sopot > 800",
    "France > Paris > 2000",
    "Albania > Tirana > 1000",
    "Bulgaria > Sofia > 200" ]);