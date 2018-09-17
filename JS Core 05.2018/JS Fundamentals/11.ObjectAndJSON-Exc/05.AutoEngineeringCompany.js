function solve(arr) {
    let cars = new Map();

    for (let line of arr) {
        let [car, model, quantity] = line.split(' | ');

        if (!cars.has(car)) {
            let currentModel = new Map();
            currentModel.set(model, +quantity);
            cars.set(car, currentModel);
        } else {
            let currentModel = cars.get(car);

            if (!currentModel.has(model)) {
                currentModel.set(model, +quantity);
            } else {
                currentModel.set(model, currentModel.get(model) + Number(quantity));
            }

            cars.set(car, currentModel);
        }
    }

    for (let [car, models] of cars) {
        console.log(`${car}`);

        for (let [model, quantity] of models) {
            console.log(`###${model} -> ${quantity}`);
        }
    }
}

solve(['Audi | Q7 | 1000', 'Audi | Q6 | 100', 'BMW | X5 | 1000',
    'BMW | X6 | 100', 'Citroen | C4 | 123', 'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000', 'Lada | Jigula | 1000000',
    'Citroen | C4 | 22', 'Citroen | C5 | 10']);