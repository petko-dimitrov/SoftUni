function solve(arr) {
    let n = Number(arr[0]);
    let x = Number(arr[1]);
    let result = 0;

    if(x >= n){
        result = x * n;
    }
    else{
        result = n / x;
    }

    console.log(result);
}