const expect = require('chai').expect;

function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

describe("isOddOrEven", function () {
   it("should return undefined with number", function () {
       let result = isOddOrEven(13);
       expect(result).to.be.equal(undefined);
   });
    it("should return even with string with length 6", function () {
        let result = isOddOrEven('peshov');
        expect(result).to.be.equal('even');
    });
    it("should return odd with string with length 5", function () {
        let result = isOddOrEven('pesho');
        expect(result).to.be.equal('odd');
    });
});