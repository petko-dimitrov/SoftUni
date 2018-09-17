function solve(arr) {
    let database = {};

    for (let line of arr) {
        let [system, component, subcomponent] = line.split(' | ');

        if (!database.hasOwnProperty(system)) {
            database[system] = {};
            database[system][component] = [subcomponent];

        } else if (!database[system].hasOwnProperty(component)) {
            database[system][component] = [subcomponent];
        } else {
            database[system][component].push(subcomponent);
        }
    }

    let sortedSystems = Object.keys(database).sort((a, b) => {
        if (Object.keys(database[a]).length === Object.keys(database[b]).length) {
            return a.localeCompare(b);
        } else {
            return Object.keys(database[b]).length - Object.keys(database[a]).length;
        }
    });

    for (let sys of sortedSystems) {
        console.log(`${sys}`);

        let sortedComponents = Object.keys(database[sys]).sort((a, b) => {
            return database[sys][b].length - database[sys][a].length;
        });

        for (let comp of sortedComponents) {
            console.log(`|||${comp}`);

            for (const subComp of database[sys][comp]) {
                console.log(`||||||${subComp}`);
            }
        }
    }
}

solve(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security']);