const expect = require('chai').expect;

class Sumator {
    constructor() {
        this.data = [];
    }
    add(item) {
        this.data.push(item);
    }
    sumNums() {
        let sum = 0;
        for (let item of this.data)
            if (typeof (item) === 'number')
                sum += item;
        return sum;
    }
    removeByFilter(filterFunc) {
        this.data = this.data.filter(x => !filterFunc(x));
    }
    toString() {
        if (this.data.length > 0)
            return this.data.join(", ");
        else
            return '(empty)';
    }
}

describe("Sumator class tests", function() {
    let sumator;
    beforeEach(function () {
        sumator = new Sumator();
    });

    describe('Data property', function () {
        it("Should have data array property", function() {
            expect(sumator.data).eql([]);
        });
        it("Should have an empty data array", function() {
            expect(sumator.data.length).equal(0);
        });
    });

    describe('Add function', function () {
        it("Should add the passed in string to the data", function() {
            sumator.add('pesho');
            expect(sumator.data.length).equal(1);
            expect(sumator.data[0]).equal('pesho');
        });
        it("Should add the passed in number to the data", function() {
            sumator.add(12);
            expect(sumator.data[0]).equal(12);
        });
        it("Should add the passed in object to the data", function() {
            sumator.add({'name':'pesho'});
            expect(sumator.data[0].name).to.equal('pesho');
        });
    });

    describe('sumNums()', function () {
        it("Should return zero", function() {
            expect(sumator.sumNums()).to.equal(0);
        });
        it("Should return 36 with arr of one number", function() {
            sumator.add(12);
            expect(sumator.sumNums()).to.equal(12);
        });
        it("Should return 36 with arr of numbers", function() {
            sumator.add(12);
            sumator.add(12);
            sumator.add(12);
            expect(sumator.sumNums()).to.equal(36);
        });
        it("Should return 36 with mixed arr", function() {
            sumator.add(12);
            sumator.add('pesho');
            sumator.add(12);
            sumator.add(12);
            expect(sumator.sumNums()).to.equal(36);
        });
        it("Should return zero with arr without numbers", function() {
            sumator.add('pesho');
            sumator.add({'name':'pesho'});
            expect(sumator.sumNums()).to.equal(0);
        });
    });

    describe('removeByFilter(filterFunc)', function () {
        beforeEach(function () {
            sumator.add(12);
            sumator.add('pesho');
            sumator.add(12);
            sumator.add(12);
            sumator.add({'name':'pesho'});
        });

        it("Should have an empty data array", function() {
            sumator.removeByFilter(x => x % 2 === 1);
            expect(sumator.data.length).to.equal(5);
        });
        it("Should have an array of 2 non-numbers", function() {
            sumator.removeByFilter(x => x % 2 === 0);
            expect(sumator.data.length).equal(2);
        });
        it("Should return pesho at 0 index", function() {
            sumator.removeByFilter(x => x % 2 === 0);
            expect(sumator.data[0]).equal('pesho');
        });
    });

    describe('toString()', function () {
        it('Should return (empty)', function () {
            expect(sumator.toString()).to.equal('(empty)');
        });
        it('Should return all data separated by comma', function () {
            sumator.add(12);
            sumator.add('pesho');
            sumator.add(12);
            expect(sumator.toString()).to.equal('12, pesho, 12');
        });
    });
});