const expect = require('chai').expect;

function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

describe("sum(arr) - sum array of numbers", function() {
    it("should return 3 for [1, 2]", function() {
        let result = sum([1, 2]);
        expect(result).to.be.equal(3);
    });
    it("should return 6 for [1, 2, 2]", function() {
        let result = sum([1, 2, 3]);
        expect(result).to.be.equal(6);
    });
    it("should return 2 for [1, 2, -1]", function() {
        let result = sum([1, 2, -1]);
        expect(result).to.be.equal(2);
    });
});
