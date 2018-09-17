function modifyNumber(number) {
    let average = 0;

    while (average <= 5) {
        let numAsStr = number.toString();
        average = 0;

        for (let i = 0; i < numAsStr.length; i++) {
            average += Number(numAsStr[i]);
        }

        average = average / numAsStr.length;

        if (average <= 5) {
            numAsStr += '9';
            number = Number(numAsStr);
        } else {
            console.log(numAsStr);
            break;
        }
    }
}

modifyNumber(101);