function findLargest3(arr){
    let numbers = arr.map(Number);
    let sorted = numbers.sort((a, b) => b - a);
    let count = Math.min(3, sorted.length);

    for (var i = 0; i < count; i++) {
        console.log(sorted[i]);
    }
}