function solve(xml) {
    let svgRegex = /<svg>.*<\/svg>/gm;
    if (!svgRegex.test(xml)) {
        console.log("No survey found");
        return;
    }

    let matches = xml.match(svgRegex);
    let catRegex = /(<cat>.*<\/cat>).*(<cat>.*<\/cat>)/g;
    let firstCatRegex = /<text>.*\[(.*)]<\/text>/g;
    let labelRegex = /\[(.+)]/g;
    let secondCatRegex = /<g>.*?<\/g>/g;
    let valueRegex = /<val>([1-9]|10)<\/val>([0-9]+)/g;
    let valueReg = /<val>(10|[1-9])/;
    let countReg = /<\/val>([0-9]+)/;

    for (let i = 0; i < matches.length; i++) {
        let totalValue = 0;
        let totalCount = 0;
        let label ='';

        let catMatches = catRegex.exec(matches[i]);
        console.log(catMatches);

        if (catMatches.length !== 3) {
            printInvalid();
            continue;
        }

        if (firstCatRegex.test(catMatches[1])) {
            label = labelRegex.exec(catMatches[1])[1];
        } else {
            printInvalid();
            continue;
        }

        if (secondCatRegex.test(catMatches[2])) {
            let groups = catMatches[2].match(secondCatRegex);

            for (let j = 0; j < groups.length; j++) {
                if (valueRegex.test(groups[j])) {
                    let valueMatches = groups[j].match(valueRegex);
                    let value = Number(valueReg.exec(valueMatches[0])[1]);
                    let count = Number(countReg.exec(valueMatches[0])[1]);
                    totalValue += value * count;
                    totalCount += count;
                }
            }
        } else {
            printInvalid();
            continue;
        }

        let avgRating = totalValue / totalCount;
        avgRating = Math.round(avgRating * 100) / 100;
        console.log(`${label}: ${avgRating}`);
    }

    function printInvalid() {
        console.log('Invalid format');
    }
}

solve('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>');