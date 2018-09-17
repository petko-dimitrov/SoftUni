function oddOrEven(number) {
    if (!Number.isInteger(number)) {
        console.log("invalid");
    } else if (number %2 === 0) {
        console.log("even");
    } else {
        console.log("odd");
    }
}

oddOrEven(1.5);