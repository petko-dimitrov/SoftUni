function round(input) {
    let number = input[0];
    let precision = input[1];

    if (precision > 15) {
        precision = 15;
    }

    let factor = Math.pow(10, precision);

    number = Math.round(number * factor) / factor;

    console.log(number);
}

round([10.5, 3]);