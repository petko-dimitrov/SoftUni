function solve(arr) {
    let products = new Map();

    for (let line of arr) {
        let [town, product, price] = line.split(' | ').filter(x => x !== '');
        price = Number(price);

        if (!products.has(product)) {
            products.set(product, new Map([[town, price]]));
        } else if (products.has(product) && !products.get(product).has(town)){
            let innerMap = products.get(product);
            for (let [key, value] of innerMap) {
                if (value > price) {
                    products.set(product, new Map([[town, price]]))
                }
            }
        } else {
            products.get(product).set(town, price);
        }
    }

    for (let [product, value] of products) {
        let result = `${product} -> `;

        for (let [town, price] of value) {
            result += `${price} (${town})`;
        }

        console.log(result);
    }
}

solve(['Sofia City | BMW | 100000',
    'Mexico City | BMW | 100000',
]);