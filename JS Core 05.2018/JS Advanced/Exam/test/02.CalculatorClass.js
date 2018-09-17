const expect = require('chai').expect;

class Calculator {
    constructor() {
        this.expenses = [];
    }

    add(data) {
        this.expenses.push(data);
    }

    divideNums() {
        let divide;
        for (let i = 0; i < this.expenses.length; i++) {
            if (typeof (this.expenses[i]) === 'number') {
                if (i === 0 || divide===undefined) {
                    divide = this.expenses[i];
                } else {
                    if (this.expenses[i] === 0) {
                        return 'Cannot divide by zero';
                    }
                    divide /= this.expenses[i];
                }
            }
        }
        if (divide !== undefined) {
            this.expenses = [divide];
            return divide;
        } else {
            throw new Error('There are no numbers in the array!')
        }
    }

    toString() {
        if (this.expenses.length > 0)
            return this.expenses.join(" -> ");
        else return 'empty array';
    }

    orderBy() {
        if (this.expenses.length > 0) {
            let isNumber = true;
            for (let data of this.expenses) {
                if (typeof data !== 'number')
                    isNumber = false;
            }
            if (isNumber) {
                return this.expenses.sort((a, b) => a - b).join(', ');
            }
            else {
                return this.expenses.sort().join(', ');
            }
        }
        else return 'empty';
    }
}

describe('Calculator class tests', function () {
    let calc;
    beforeEach(function () {
       calc = new Calculator();
    });
    describe('Property expenses', function () {
        it('should have an empty array expenses', function () {
            expect(calc.expenses.length).to.equal(0);
        });
        it('should have an empty array expenses', function () {
            expect(typeof calc.expenses).to.equal('object');
        });
        it('should have an empty array expenses', function () {
            expect(calc.expenses[0]).to.equal(undefined);
        });
    });
    describe('Function add(data)', function () {
        it('should have add function', function () {
            expect(typeof calc.add).to.equal('function');
            expect(Calculator.prototype.hasOwnProperty('add')).to.equal(true);
        });
        it('should add string to expenses', function () {
            calc.add('pesho');
            expect(calc.expenses.length).to.equal(1);
            expect(calc.expenses[0]).to.equal('pesho');
        });
        it('should add number to expenses', function () {
            calc.add(3);
            expect(calc.expenses.length).to.equal(1);
            expect(calc.expenses[0]).to.equal(3);
        });
        it('should add floating-point number to expenses', function () {
            calc.add(3.14);
            expect(calc.expenses.length).to.equal(1);
            expect(calc.expenses[0]).to.equal(3.14);
        });
        it('should add object to expenses', function () {
            calc.add({'name': 'kiro'});
            expect(calc.expenses.length).to.equal(1);
            expect(calc.toString()).to.equal('[object Object]');
        });
        it('should add multiple elements to expenses', function () {
            calc.add({'name': 'kiro'});
            calc.add(0);
            calc.add('pesho');
            calc.add(-3);
            expect(calc.expenses.length).to.equal(4);
            expect(calc.toString()).to.equal('[object Object] -> 0 -> pesho -> -3');
        });
    });
    describe('Function divideNums()', function () {
        it('should have divideNums function', function () {
            expect(typeof calc.divideNums).to.equal('function');
            expect(Calculator.prototype.hasOwnProperty('divideNums')).to.equal(true);
        });
        it('should divide two positive numbers', function () {
            calc.add(6);
            calc.add(3);
            expect(calc.divideNums()).to.equal(2);
        });
        it('should throw error with two positive numbers as strings', function () {
            calc.add('6');
            calc.add('3');
            expect(() => calc.divideNums()).throw('There are no numbers in the array!');
        });
        it('should return the number with one number', function () {
            calc.add(-6);
            expect(calc.divideNums()).to.equal(-6);
        });
        it('should return the number with one number', function () {
            calc.add(-6);
            calc.add('3');
            expect(calc.divideNums()).to.equal(-6);
        });
        it('should return zero only with one zero', function () {
            calc.add(0);
            expect(calc.divideNums()).to.equal(0);
        });
        it('should divide three positive numbers', function () {
            calc.add(6);
            calc.add(3);
            calc.add('pesho');
            calc.add(2);
            expect(calc.divideNums()).to.equal(1);
        });
        it('should divide two negative numbers', function () {
            calc.add(-6);
            calc.add(-4);
            expect(calc.divideNums()).to.equal(1.5);
        });
        it('should divide two floating-point numbers', function () {
            calc.add(4.5);
            calc.add('pesho');
            calc.add(2.2);
            expect(calc.divideNums()).to.closeTo(2.04, 0.01);
        });
        it('should divide mixed numbers', function () {
            calc.add(4.5);
            calc.add('pesho');
            calc.add(-2.2);
            calc.add(3);
            expect(calc.divideNums()).to.closeTo(-0.68, 0.01);
        });
        it('should divide by zero', function () {
            calc.add(4);
            calc.add(0);
            expect(calc.divideNums()).to.equal('Cannot divide by zero');
        });
        it('should divide by zero', function () {
            calc.add(4);
            calc.add('pesho');
            calc.add(4);
            calc.add(0);
            expect(calc.divideNums()).to.equal('Cannot divide by zero');
        });
        it('should throw error with no numbers', function () {
            calc.add('pesho');
            calc.add('pesho');
            calc.add('pesho');
            expect(() => calc.divideNums()).throw('There are no numbers in the array!');
        });
    });
    describe('Function toString()', function () {
        it('should have toString function', function () {
            expect(typeof calc.toString).to.equal('function');
            expect(Calculator.prototype.hasOwnProperty('toString')).to.equal(true);
        });
        it('should return the element with one expense', function () {
            calc.add('pesho');
            expect(calc.toString()).to.equal('pesho');
        });
        it('should return the element with one expense', function () {
            calc.add(6);
            expect(calc.toString()).to.equal('6');
        });
        it('should print all elements', function () {
            calc.add(6);
            calc.add(-6);
            calc.add(6.6);
            calc.add('kiro');
            expect(calc.toString()).to.equal('6 -> -6 -> 6.6 -> kiro');
        });
        it('should return empty array with no expenses', function () {
            expect(calc.toString()).to.equal('empty array');
        });
    });
    describe('Function orderBy()', function () {
        it('should have orderBy function', function () {
            expect(typeof calc.orderBy).to.equal('function');
            expect(Calculator.prototype.hasOwnProperty('orderBy')).to.equal(true);
        });
        it('should sort three numbers', function () {
            calc.add(6);
            calc.add(-6);
            calc.add(6.6);
            expect(calc.orderBy()).to.equal('-6, 6, 6.6')
        });
        it('should sort three strings', function () {
            calc.add('kiro');
            calc.add('gogo');
            calc.add('6.6');
            expect(calc.orderBy()).to.equal('6.6, gogo, kiro');
        });
        it('should sort three mixed elements', function () {
            calc.add('kiro');
            calc.add(-2);
            calc.add(6.5);
            calc.add({'name': 'gogo'});
            expect(calc.orderBy()).to.equal('-2, 6.5, [object Object], kiro');
        });
        it('should sort one element', function () {
            calc.add('kiro');
            expect(calc.orderBy()).to.equal('kiro');
        });
        it('should return empty with no elements', function () {
            expect(calc.orderBy()).to.equal('empty');
        });
    });
});