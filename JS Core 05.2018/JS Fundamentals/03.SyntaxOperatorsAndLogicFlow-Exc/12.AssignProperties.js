function assignProperties(input) {
    let firstProp = input[0];
    let firstValue = input[1];
    let secondProp = input[2];
    let secondValue = input[3];
    let thirdProp = input[4];
    let thirdValue = input[5];

    let obj = {};
    obj[firstProp] = firstValue;
    obj[secondProp] = secondValue;
    obj[thirdProp] = thirdValue;

    console.log(obj);
}

assignProperties(['name', 'Pesho', 'age', '23', 'gender', 'male']);

