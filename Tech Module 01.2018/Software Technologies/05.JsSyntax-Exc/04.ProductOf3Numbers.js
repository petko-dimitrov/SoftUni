function solve(arr) {
    let numbers = arr.map(Number);
    let count = 0;

    for (let i = 0; i < numbers.length; i++) {
        if(numbers[i] < 0){
            count++;
        }
    }

    if(count % 2 != 0){
        console.log('Negative');
    }
    else{
        console.log('Positive');
    }
}