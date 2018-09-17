function solve() {
    let microelements = {'protein': 0, 'carbohydrate': 0, 'fat': 0, 'flavour': 0};

    return function manager (input) {
        let [command, element, value] = input.split(' ');

        switch (command) {
            case 'restock':
                microelements[element] = microelements[element] + Number(value);
                return 'Success';
            case 'prepare':
                if (element === 'apple') {
                    if (microelements['carbohydrate'] - value * 1 < 0) {
                        return `Error: not enough carbohydrate in stock`;

                    } else if (microelements['flavour'] - value * 2 < 0) {
                        return `Error: not enough flavour in stock`;
                    } else {
                        microelements['carbohydrate'] -= value * 1;
                        microelements['flavour'] -= value * 2;
                        return 'Success';
                    }
                } else if (element === 'coke') {
                    if (microelements['carbohydrate'] - value * 10 < 0) {
                        return `Error: not enough carbohydrate in stock`;

                    } else if (microelements['flavour'] - value * 20 < 0) {
                        return `Error: not enough flavour in stock`;
                    } else {
                        microelements['carbohydrate'] -= value * 10;
                        microelements['flavour'] -= value * 20;
                        return 'Success';
                    }
                } else if (element === 'burger') {
                    if (microelements['carbohydrate'] - value * 5 < 0) {
                        return `Error: not enough carbohydrate in stock`;

                    } else if (microelements['fat'] - value * 7 < 0) {
                        return `Error: not enough fat in stock`;
                    } else if (microelements['flavour'] - value * 3 < 0) {
                        return `Error: not enough flavour in stock`;
                    } else {
                        microelements['carbohydrate'] -= value * 5;
                        microelements['fat'] -= value * 7;
                        microelements['flavour'] -= value * 3;
                        return 'Success';
                    }
                } else if (element === 'omelet') {
                    if (microelements['protein'] - value * 5 < 0) {
                        return `Error: not enough protein in stock`;

                    } else if (microelements['fat'] - value * 1 < 0) {
                        return `Error: not enough fat in stock`;
                    } else if (microelements['flavour'] - value * 1 < 0) {
                        return `Error: not enough flavour in stock`;
                    } else {
                        microelements['protein'] -= value * 5;
                        microelements['fat'] -= value * 1;
                        microelements['flavour'] -= value * 1;
                        return 'Success';
                    }
                } else if (element === 'cheverme') {
                    if (microelements['carbohydrate'] - value * 10 < 0) {
                        return `Error: not enough carbohydrate in stock`;
                    } else if (microelements['protein'] - value * 10 < 0) {
                        return `Error: not enough protein in stock`;
                    } else if (microelements['fat'] - value * 10 < 0) {
                        return `Error: not enough fat in stock`;
                    } else if (microelements['flavour'] - value * 10 < 0) {
                        return `Error: not enough flavour in stock`;
                    } else {
                        microelements['protein'] -= value * 10;
                        microelements['fat'] -= value * 10;
                        microelements['flavour'] -= value * 10;
                        microelements['carbohydrate'] -= value * 10;
                        return 'Success';
                    }
                }
                break;
            case 'report':
                return `protein=${microelements['protein']} carbohydrate=${microelements['carbohydrate']} fat=${microelements['fat']} flavour=${microelements['flavour']}`;
            default:
                break;
        }
    }
}

let manager = solve();
console.log(manager("restock flavour 50"));
console.log(manager("prepare coke 4"));
console.log(manager("report"));