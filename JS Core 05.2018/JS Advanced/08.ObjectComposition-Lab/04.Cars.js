function solve(arr) {
    let cars = {};

    let carsCreator = {
        create: (tokens) => {
            let name = tokens[0];

            if (tokens.length > 2) {
                let parent = tokens[2];
                let newObj = Object.create(cars[parent]);
                cars[name] = newObj;
            } else {
                cars[name] = {};
            }
        },

        set: (tokens) => {
            let name = tokens[0];
            let key = tokens[1];
            cars[name][key] = tokens[2];
        },

        print: (tokens) => {
            let name = tokens[0];
            let obj = cars[name];
            let properties = [];
            for (const objKey in obj) {
                properties.push(`${objKey}:${obj[objKey]}`);
            }
            console.log(properties.join(', '));
        }

    };

    for (const line of arr) {
        let tokens = line.split(' ');
        let command = tokens.shift();
        carsCreator[command](tokens);
    }
}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']);