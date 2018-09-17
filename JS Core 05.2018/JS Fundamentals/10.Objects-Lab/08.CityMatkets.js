function solve(arr) {
    let towns = new Map();

    for (let line of arr) {
        let [town, product, salesInfo] = line.split(' -> ').filter(x => x !== '');
        let [amount, price] = salesInfo.split(' : ').filter(x => x !== '').map(x => Number(x));
        let income = amount * price;

        if (!towns.has(town)) {
            towns.set(town, new Map([[product, income]]));
        } else {
            towns.get(town).set(product, income);
        }
    }

    for (let [town, value] of towns) {
        console.log(`Town - ${town}`);

        for (let [product, income] of value) {
            console.log(`$$$${product} : ${income}`);
        }
    }
}

solve(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3']);