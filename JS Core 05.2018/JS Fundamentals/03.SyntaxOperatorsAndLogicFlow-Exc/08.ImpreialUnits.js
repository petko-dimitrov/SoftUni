function convertInchesToFeet(inches) {
    let feet = Math.floor(inches / 12);
    let remainderInches = inches % 12;

    console.log(`${feet}'-${remainderInches}"`);
}

convertInchesToFeet(55);