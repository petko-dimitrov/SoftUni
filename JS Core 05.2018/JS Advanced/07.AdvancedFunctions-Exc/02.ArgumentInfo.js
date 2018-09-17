function solve() {
    let argTypes = {};

    for (const argument of arguments) {
        console.log(`${typeof argument}: ${argument}`);

        if (!argTypes.hasOwnProperty(typeof argument)) {
            argTypes[typeof argument] = 1;
        } else {
            argTypes[typeof argument]++;
        }
    }

    let sortedArgtypes = Object.keys(argTypes).sort((a, b) => {
        return argTypes[b] - argTypes[a];
    });

    for (const argType of sortedArgtypes) {
        console.log(`${argType} = ${argTypes[argType]}`);
    }
}

solve({ name: 'bob'}, 3.333, 9.999);