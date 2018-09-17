function solve(arr) {
    let [startIndex, endIndex, replaceString, text] = arr;
    startIndex = Number(startIndex);
    endIndex = Number(endIndex);

    let countryRegex = /\b[A-Z]\S+[A-Z]\b/;
    let country = '';

    if (countryRegex.test(text)) {
        country = text.match(countryRegex)[0];
        let subStr = country.substring(startIndex, endIndex + 1);
        country = country.replace(subStr, replaceString);
        let lastLetter = country.slice(country.length - 1).toLowerCase();
        country = country.slice(0, country.length - 1) + lastLetter;
    }

    let numberRegex = /[0-9]{3}\.*[0-9]*/gm;
    let numbers = [];

    if (numberRegex.test(text)) {
        numbers = text.match(numberRegex);
        numbers = numbers.map(x => Math.ceil(x));
    }

    let town = '';

    for (let number of numbers) {
        town += String.fromCharCode(+number);
    }

    town = town.toLowerCase();
    let firstLetter = town.slice(0, 1).toUpperCase();
    town = firstLetter + town.slice(1);

    if (country) {
        console.log(`${country} => ${town}`);
    }
}

solve(["3", "5", "gar","114 sDfia 1, " +
"riDl10 confin$4%#ed117 likewise it humanity aTe114.223432 BultoriA - Varnd railLery101 an unpacked as he"]);