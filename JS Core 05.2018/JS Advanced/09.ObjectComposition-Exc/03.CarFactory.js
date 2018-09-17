function solve(car) {
    let newCar = {};
    newCar.model = car.model;
    newCar.engine = {};

    if (car.power <= 90) {
        newCar.engine.power = 90;
        newCar.engine.volume = 1800;
    } else if (car.power <= 120) {
        newCar.engine.power = 120;
        newCar.engine.volume = 2400;
    } else {
        newCar.engine.power = 200;
        newCar.engine.volume = 3500;
    }

    newCar.carriage = {};
    newCar.carriage.type = car.carriage;
    newCar.carriage.color = car.color;

    newCar.wheels = [];
    if (car.wheelsize % 2 === 0) {
        car.wheelsize--;
    }
    for (let i = 0; i < 4; i++) {
        newCar.wheels.push(car.wheelsize);
    }

    return newCar;
}

console.log(solve({ model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14 }));