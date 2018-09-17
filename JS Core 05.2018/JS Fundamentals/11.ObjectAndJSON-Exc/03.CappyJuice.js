function solve(arr) {
    let quantities = {};
    let bottles = new Map();

    for (let arrElement of arr) {
        let juiceInfo = arrElement.split(' => ');
        let fruit = juiceInfo[0];
        let quantity = Number(juiceInfo[1]);

        if (!quantities.hasOwnProperty(fruit)) {
            quantities[fruit] = quantity;
        } else {
            quantities[fruit] += quantity;
        }

        if (quantities[fruit] >= 1000) {
            if (!bottles.has(fruit)) {
                bottles.set(fruit, Math.floor(quantities[fruit] / 1000));
            } else {
                bottles.set(fruit, bottles.get(fruit) + Math.floor(quantities[fruit] / 1000));
            }

            quantities[fruit] -= Math.floor(quantities[fruit] / 1000) * 1000;
        }
    }

    for (let [key, value] of bottles) {
        console.log(`${key} => ${value}`);
    }
}

solve(['Orange => 2000',
'Peach => 1432',
'Banana => 450',
'Peach => 600',
'Strawberry => 549']);