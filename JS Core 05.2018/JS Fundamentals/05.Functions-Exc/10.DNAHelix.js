function printHelix(n) {
    let symbols = "ATCGTTAGGG";
    let index = 0;

    for (let i = 0; i < n; i++) {
        if (index > 9){
            index = 0;
        }
        if (i % 4 === 0){
            console.log(`**${symbols[index]}${symbols[index+1]}**`);
        } else if (i % 4 === 1 || i % 4 === 3) {
            console.log(`*${symbols[index]}--${symbols[index+1]}*`);
        } else {
            console.log(`${symbols[index]}----${symbols[index+1]}`);
        }

        index += 2;
    }
}

printHelix(10);