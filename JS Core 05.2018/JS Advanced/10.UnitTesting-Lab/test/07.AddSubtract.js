const expect = require('chai').expect;

function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}

describe("Test createCalculator()", function () {
    let calc;
    beforeEach(function () {
        calc = createCalculator();
    });

    it("should return 0 after get", function () {
        let result = calc.get();
        expect(result).to.be.equal(0);
    });
    it("should return 5 after add(2); add(3); get ", function () {
        calc.add(2);
        calc.add(3);
        let result = calc.get();
        expect(result).to.be.equal(5);
    });
    it("should return 5 after subtract(2); subtract(3); get ", function () {
        calc.subtract(2);
        calc.subtract(3);
        let result = calc.get();
        expect(result).to.be.equal(-5);
    });
    it("should return 4.2 after add(5.3); subtract(1.1); get  ", function () {
        calc.add(5.3);
        calc.subtract(1.1);
        let result = calc.get();
        expect(result).to.be.equal(4.2);
    });
    it("should return 2 after add(10); subtract('7'); add('-2'); subtract(-1); get ", function () {
        calc.add(10);
        calc.subtract('7');
        calc.add('-2');
        calc.subtract(-1);
        let result = calc.get();
        expect(result).to.be.equal(2);
    });
    it("should return NaN after add('hello'); get", function () {
        calc.add('hello');
        let result = calc.get();
        expect(result).is.NaN;
    });
    it("should return NaN after subtract('hello'); get", function () {
        calc.subtract('hello');
        let result = calc.get();
        expect(result).is.NaN;
    });
});