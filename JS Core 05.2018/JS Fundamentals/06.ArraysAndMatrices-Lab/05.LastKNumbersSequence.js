function solve(n, k) {
    let arr = [1];

    for (let i = 1; i < n; i++) {
        let startIndex = Math.max(0, arr.length - k);
        let sum = arr.slice(startIndex, startIndex + k).reduce((a, b) => a + b);
        arr.push(sum);
    }

    console.log(arr.join(' '));
}

solve(6, 3);