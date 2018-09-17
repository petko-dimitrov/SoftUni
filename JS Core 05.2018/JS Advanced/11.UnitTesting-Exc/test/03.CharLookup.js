const expect = require('chai').expect;

function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

describe('lookupChar', function () {
    it("first argument should be a string", function () {
        let result = lookupChar(111, 1);
        expect(result).to.be.equal(undefined);
    });
    it("second argument should be an integer", function () {
        let result = lookupChar('pesho', '1');
        expect(result).to.be.equal(undefined);
    });
    it("second argument should be an integer", function () {
        let result = lookupChar('pesho', 1.5);
        expect(result).to.be.equal(undefined);
    });
    it("arguments should be of valid type", function () {
        let result = lookupChar(13, '1');
        expect(result).to.be.equal(undefined);
    });
    it("the index should be within the length of the string", function () {
        let result = lookupChar('pesho', -1);
        expect(result).to.be.equal("Incorrect index");
    });
    it("the index should be within the length of the string", function () {
        let result = lookupChar('pesho', 100);
        expect(result).to.be.equal("Incorrect index");
    });
    it("the index should be within the length of the string", function () {
        let result = lookupChar('pesho', 1);
        expect(result).to.be.equal("e");
    });
    it("the index should be within the length of the string", function () {
        let result = lookupChar('pesho', 4);
        expect(result).to.be.equal("o");
    });
});