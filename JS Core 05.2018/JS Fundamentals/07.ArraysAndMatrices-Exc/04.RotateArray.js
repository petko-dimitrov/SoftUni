function rotate(arr) {
    let numOfRotations = Number(arr.pop());
    numOfRotations = numOfRotations % arr.length;

    for (let i = 0; i < numOfRotations; i++) {
        let lastElement = arr.pop();
        arr.unshift(lastElement);
    }

    console.log(arr.join(' '));
}

rotate(['Banana', 'Orange', 'Coconut', 'Apple', '15']);

