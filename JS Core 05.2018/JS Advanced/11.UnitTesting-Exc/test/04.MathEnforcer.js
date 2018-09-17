const expect = require('chai').expect;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};

describe('mathEnforcer', function () {
    describe('addFive', function () {
        it('Argument should be a number.', function () {
            let result = mathEnforcer.addFive('5');
            expect(result).to.equal(undefined);
        });
        it('Should return 10 with input 5.', function () {
            let result = mathEnforcer.addFive(5);
            expect(result).to.be.equal(10);
        });
        it('Should return 0 with input -5.', function () {
            let result = mathEnforcer.addFive(-5);
            expect(result).to.be.equal(0);
        });
        it('Should return 10.1 with input 5.1.', function () {
            let result = mathEnforcer.addFive(5.13);
            expect(result).to.be.closeTo(10.13, 0.01);
        });
    });
    describe('subtractTen', function () {
        it('Argument should be a number.', function () {
            let result = mathEnforcer.subtractTen('5');
            expect(result).to.equal(undefined);
        });
        it('Should return 10 with input 20.', function () {
            let result = mathEnforcer.subtractTen(20);
            expect(result).to.be.equal(10);
        });
        it('Should return -30 with input -20.', function () {
            let result = mathEnforcer.subtractTen(-20);
            expect(result).to.be.equal(-30);
        });
        it('Should return 9.5 with input 19.5.', function () {
            let result = mathEnforcer.subtractTen(19.51);
            expect(result).to.be.closeTo(9.51, 0.01);
        });
    });
    describe('sum', function () {
        it('Arguments should be numbers.', function () {
            let result = mathEnforcer.sum('5', 5);
            expect(result).to.equal(undefined);
        });
        it('Arguments should be numbers.', function () {
            let result = mathEnforcer.sum('5', 5);
            expect(result).to.equal(undefined);
        });
        it('Should return 10 with input (7, 3).', function () {
            let result = mathEnforcer.sum(7, 3);
            expect(result).to.be.equal(10);
        });
        it('Should return 10.5 with input (7.5, 3).', function () {
            let result = mathEnforcer.sum(7.5, 3);
            expect(result).to.be.equal(10.5);
        });
        it('Should return 9.9 with input (7.5, 2.4).', function () {
            let result = mathEnforcer.sum(7.5, 2.49);
            expect(result).to.be.closeTo(9.99, 0.01);
        });
        it('Should return -10 with input (-7, -3).', function () {
            let result = mathEnforcer.sum(-7, -3);
            expect(result).to.be.equal(-10);
        });
        it('Should return 4 with input (7, -3).', function () {
            let result = mathEnforcer.sum(7.55, -3);
            expect(result).to.be.closeTo(4.55, 0.01);
        });
        it('Should return 0 with input (0, 0).', function () {
            let result = mathEnforcer.sum(0, 0);
            expect(result).to.be.equal(0);
        });
        it('Should return 5 after sum(5, 5), addFive(result), subtractTen(result).', function () {
            let result = mathEnforcer.sum(5, 5);
            expect(result).to.be.equal(10);
            result = mathEnforcer.addFive(result);
            expect(result).to.be.equal(15);
            result = mathEnforcer.subtractTen(result);
            expect(result).to.be.equal(5);
        });
    });
});