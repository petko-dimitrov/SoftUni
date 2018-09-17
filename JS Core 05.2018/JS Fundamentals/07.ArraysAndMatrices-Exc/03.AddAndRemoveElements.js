function addAndRemove(arr) {
    let number = 1;
    let resultArray = [];

    for (let i = 0; i < arr.length; i++) {
        let command = arr[i];

        if (command === 'add'){
            resultArray.push(number);
        } else {
            resultArray.pop();
        }

        number++;
    }

    if (resultArray.length !== 0){
        console.log(resultArray.join('\n'));
    } else {
        console.log('Empty');
    }
}

addAndRemove(['add', "add", 'remove', "add", "add"]);