function solve(arr) {
    let companiesStr = arr.shift();
    let delimiter = arr.shift();
    let companies = companiesStr.split(delimiter);
    arr = arr.map(x => x.toLowerCase());
    let validSentences = [];
    let invalidSentences = [];

    for (let line of arr) {
        let isValid = true;

        for (let company of companies) {
            if (line.indexOf(company) < 0) {
                isValid = false;
                break;
            }
        }

        if (isValid) {
            validSentences.push(line);
        } else {
            invalidSentences.push(line);
        }
    }

    if (validSentences.length > 0) {
        console.log("ValidSentences");
        for (let i = 0; i < validSentences.length; i++) {
            console.log(`${i+1}. ${validSentences[i]}`);
        }
    }

    if (validSentences.length > 0 && invalidSentences.length > 0) {
        console.log('==============================');
    }

    if (invalidSentences.length > 0) {
        console.log('InvalidSentences');
        for (let i = 0; i < invalidSentences.length; i++) {
            console.log(`${i+1}. ${invalidSentences[i]}`);
        }
    }
}

solve(["bulgariatour@, minkatrans@, koftipochivkaltd",
    "@,",
    "Mincho e KoftiPochivkaLTD Tip 123  ve MinkaTrans BulgariaTour",
    "dqdo mraz some text but is KoftiPochivkaLTD MinkaTrans",
    "someone continues as no "]);