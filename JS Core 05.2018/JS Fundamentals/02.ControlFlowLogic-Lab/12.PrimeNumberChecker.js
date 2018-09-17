function checkIfPrime(number) {
    let isPrime = true;

    if(number < 2){
        isPrime = false;
        console.log(isPrime);
        return;
    }

    for (let i = 2; i < Math.sqrt(number); i++) {
        if(number % i === 0) {
            isPrime = false;
            break;
        }
    }

    console.log(isPrime);
}

checkIfPrime(2);