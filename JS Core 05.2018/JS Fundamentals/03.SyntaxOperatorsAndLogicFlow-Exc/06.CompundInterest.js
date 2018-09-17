function findInterest(input) {
    let sum = input[0];
    let interestRate = input[1];
    let compoundingPeriod = input[2];
    let totalTimespan = input[3];
    let compoundingFrequency = 12 / compoundingPeriod;

    let compoundInterest = sum * Math.pow((1 + interestRate / 100 / compoundingFrequency),
        totalTimespan * compoundingFrequency);

    console.log(compoundInterest.toFixed(2));
}

findInterest([1500, 4.3, 3, 6]);