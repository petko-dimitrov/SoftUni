function concatenateNumbers(number) {
    let str = '';

    for (let i = 1; i <= parseInt(number); i++) {
        str += i;
    }

    console.log(str);
}

concatenateNumbers('11');