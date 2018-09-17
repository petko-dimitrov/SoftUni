function solve(arr) {
    arr = arr.map(x => Number(x)).sort((a, b) => a - b);
    let pesos = 0;
    let concrete = [];
    arr = arr.filter(x => x < 30);

    while (arr.length > 0) {
        let dailyConcrete = arr.length * 195;
        pesos += dailyConcrete * 1900;
        concrete.push(dailyConcrete);
        arr = arr.map(x => x = x + 1);
        arr = arr.filter(x => x < 30);
    }

    console.log(concrete.join(', '));
    console.log(`${pesos} pesos`);
}

solve(['30']);