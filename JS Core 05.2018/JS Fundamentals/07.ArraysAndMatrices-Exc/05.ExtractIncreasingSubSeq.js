function extractSubSeq(arr) {
    let biggestNum = Number.NEGATIVE_INFINITY;

    for (let i = 0; i < arr.length; i++) {
        if (biggestNum <= arr[i]){
            biggestNum = arr[i];
            console.log(arr[i]);
        }
    }
}

extractSubSeq([1, 3, 8, 4, 10, 12, 3 ,2 ,24]);