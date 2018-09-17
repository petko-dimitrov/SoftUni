const expect = require('chai').expect;

function isSymmetric(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}

describe("Check if an array is symmetric", function () {
    it("should be an array", function () {
        let result = isSymmetric('Pesho');
        expect(result).to.be.equal(false);
    });
    it("should return true for [2]", function () {
        let result = isSymmetric([2]);
        expect(result).to.be.equal(true);
    });
    it("should return true for [1, 2, 1]", function () {
        let result = isSymmetric([1, 2, 1]);
        expect(result).to.be.equal(true);
    });
    it("should return true for [1, 3, 2, 3, 1]", function () {
        let result = isSymmetric([1, 3, 2, 3, 1]);
        expect(result).to.be.equal(true);
    });
    it("should return true for [1, 3, 'Pesho', 3, 1]", function () {
        let result = isSymmetric([1, 3, 'Pesho', 3, 1]);
        expect(result).to.be.equal(true);
    });
    it("should return true for [1, {a:3}, 'Pesho', {a:3}, 1]", function () {
        let result = isSymmetric([1, {a:3}, 'Pesho', {a:3}, 1]);
        expect(result).to.be.equal(true);
    });
    it("should return false for [1, 1, 2, 3, 1]", function () {
        let result = isSymmetric([1, 1, 2, 3, 1]);
        expect(result).to.be.equal(false);
    });
    it("should return false for [2, 3, 3, 3, 1]", function () {
        let result = isSymmetric([2, 3, 3, 3, 1]);
        expect(result).to.be.equal(false);
    });
    it("should return false for [2, 'p', 3, 'g', 1]", function () {
        let result = isSymmetric([2, 'p', 3, 'g', 1]);
        expect(result).to.be.equal(false);
    });
    it("should return false for [1, {a:3}, 'Pesho', {a:3}, 1]", function () {
        let result = isSymmetric([1, {a:4}, 'Pesho', {a:3}, 1]);
        expect(result).to.be.equal(false);
    });
});