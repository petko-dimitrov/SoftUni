function solve(arr) {
    let catalogue = {};

    for (let line of arr) {
        let [product, price] = line.split(' : ');
        let letter = product[0];

        if (!catalogue.hasOwnProperty(letter)) {
            catalogue[letter] = {};
            catalogue[letter][product] = +price;
        } else {
            catalogue[letter][product] = +price;
        }
    }

    let sortedLetters = Object.keys(catalogue).sort();

    for (let letter of sortedLetters) {
        console.log(letter);
        let sortedProducts = Object.keys(catalogue[letter]).sort();

        for (let product of sortedProducts) {
            console.log(`  ${product}: ${catalogue[letter][product]}`);
        }
    }
}

solve(['Appricot : 20.4', 'Fridge : 1500', 'TV : 1499',
    'Deodorant : 10', 'Boiler : 300', 'Apple : 1.25', 'Anti-Bug Spray : 15',
    'T-Shirt : 10']);