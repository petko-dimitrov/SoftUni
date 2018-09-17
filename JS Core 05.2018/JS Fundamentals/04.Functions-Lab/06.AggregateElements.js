function aggregate(elements) {
    let sum = function (elements) {
        let result = 0;

        for (let i = 0; i < elements.length; i++) {
            result += elements[i];
        }

        console.log(result);
    };

    let sumInverse = function (elements) {
        let result = 0;

        for (let i = 0; i < elements.length; i++) {
            result += 1 / elements[i];
        }

        console.log(result);
    };

    let concat = function (elements) {
        let result = '';

        for (let i = 0; i < elements.length; i++) {
            result += elements[i];
        }

        console.log(result);
    };

    sum(elements);
    sumInverse(elements);
    concat(elements);
}

aggregate([1, 2, 3]);