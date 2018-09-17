const expect = require('chai').expect;

function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

describe("rgbToHexColor", function () {
   describe("check if red is valid", function () {
       it("should return undefined if NaN", function () {
           let result = rgbToHexColor('pesho', 0, 0);
           expect(result).to.be.equal(undefined);
       });
       it("should return undefined if red < 0", function () {
           let result = rgbToHexColor(-1, 0, 0);
           expect(result).to.be.equal(undefined);
       });
       it("should return undefined if red > 255", function () {
           let result = rgbToHexColor(300, 0, 0);
           expect(result).to.be.equal(undefined);
       });
   });
    describe("check if green is valid", function () {
        it("should return undefined if NaN", function () {
            let result = rgbToHexColor(1, 'g', 0);
            expect(result).to.be.equal(undefined);
        });
        it("should return undefined if green < 0", function () {
            let result = rgbToHexColor(3, -3, 0);
            expect(result).to.be.equal(undefined);
        });
        it("should return undefined if green > 255", function () {
            let result = rgbToHexColor(3, 275, 0);
            expect(result).to.be.equal(undefined);
        });
    });
    describe("check if blue is valid", function () {
        it("should return undefined if NaN", function () {
            let result = rgbToHexColor(4, 0, 'p');
            expect(result).to.be.equal(undefined);
        });
        it("should return undefined if blue < 0", function () {
            let result = rgbToHexColor(1, 0, -90);
            expect(result).to.be.equal(undefined);
        });
        it("should return undefined if blue > 255", function () {
            let result = rgbToHexColor(3, 0, 300);
            expect(result).to.be.equal(undefined);
        });
    });
    describe("check if rgbToHexColor converts properly", function () {
        it("should return #4286F4 for (66, 134, 244)", function () {
            let result = rgbToHexColor(66, 134, 244);
            expect(result).to.be.equal('#4286F4');
        });
        it("should return #000000 for (0, 0, 0)", function () {
            let result = rgbToHexColor(0, 0, 0);
            expect(result).to.be.equal('#000000');
        });
        it("should return #FFFFFF for (255, 255, 255)", function () {
            let result = rgbToHexColor(255, 255, 255);
            expect(result).to.be.equal('#FFFFFF');
        });
    })
});