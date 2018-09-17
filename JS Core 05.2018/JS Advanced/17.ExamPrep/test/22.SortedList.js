const expect = require('chai').expect;

class SortedList {
    constructor() {
        this.list = [];
    }

    add(element) {
        this.list.push(element);
        this.sort();
    }

    remove(index) {
        this.vrfyRange(index);
        this.list.splice(index, 1);
    }

    get(index) {
        this.vrfyRange(index);
        return this.list[index];
    }

    vrfyRange(index) {
        if (this.list.length == 0) throw new Error("Collection is empty.");
        if (index < 0 || index >= this.list.length) throw new Error("Index was outside the bounds of the collection.");
    }

    sort() {
        this.list.sort((a, b) => a - b);
    }

    get size() {
        return this.list.length;
    }
}

describe('SortedList class tests', function () {
    let sortedList;
    beforeEach(function () {
       sortedList = new SortedList();
    });
    describe('Maintains a collection of numeric elements', function () {
        it('should have empty array at initialization', function () {
            expect(sortedList.list.length).to.equal(0);
            expect(typeof sortedList.list).to.equal('object');
            expect(sortedList.list).to.be.an('array')
        });
        it('should have add remove, get and size', function () {
            expect(typeof sortedList.add).to.equal('function');
            expect(typeof sortedList.remove).to.equal('function');
            expect(typeof sortedList.get).to.equal('function');
            expect(typeof sortedList.size).to.equal('number');
        });
        it("should have all of the functions in it's prototype", function() {
            expect(SortedList.prototype.hasOwnProperty('add')).to.equal(true);
            expect(SortedList.prototype.hasOwnProperty('remove')).to.equal(true);
            expect(SortedList.prototype.hasOwnProperty('get')).to.equal(true);
        });

        it("should have size property getter", function() {
            expect(SortedList.prototype.hasOwnProperty('size')).to.equal(true);
            expect(typeof sortedList.size).to.not.equal('function');
        });
    });
    describe('add(element) function', function () {
        it('should have add(element) at initialization', function () {
            expect(typeof sortedList.add).to.equal('function');
        });
        it('should add an element', function () {
            sortedList.add(3);
            expect(sortedList.list[0]).to.equal(3);
            expect(sortedList.list.length).to.equal(1);
        });
        it('should add three elements and sort them', function () {
            sortedList.add(3);
            sortedList.add(1);
            sortedList.add(5);
            expect(sortedList.list[0]).to.equal(1);
            expect(sortedList.list.length).to.equal(3);
            expect(sortedList.list.join(' ')).to.equal('1 3 5');
        });
    });
    describe('remove(index)', function () {
        beforeEach(function () {
            sortedList.add(3);
            sortedList.add(1);
            sortedList.add(5);
        });
        it('should remove at zero index', function () {
            sortedList.remove(0);
            expect(sortedList.size).to.equal(2);
            expect(sortedList.list[0]).to.equal(3);
        });
        it('should remove at last index', function () {
            sortedList.remove(2);
            expect(sortedList.size).to.equal(2);
            expect(sortedList.list[1]).to.equal(3);
        });
        it('should throw error at invalid index', function () {
            expect(() =>sortedList.remove(3)).throw(Error);
            expect(() =>sortedList.remove(-1)).throw(Error);
        });
        it('should throw error with empty list', function () {
            sortedList.remove(0);
            sortedList.remove(0);
            sortedList.remove(0);
            expect(() =>sortedList.remove(0)).throw(Error);
        });
    });
    describe('get(index)', function () {
        beforeEach(function () {
            sortedList.add(3);
            sortedList.add(1);
            sortedList.add(5);
        });
        it('should return valid result', function () {
            expect(sortedList.get(0)).to.equal(1);
            expect(sortedList.get(2)).to.equal(5);
        });
        it('should throw error at invalid index', function () {
            expect(() =>sortedList.get(3)).throw(Error);
            expect(() =>sortedList.get(-1)).throw(Error);
        });
        it('should throw error with empty list', function () {
            sortedList.remove(0);
            sortedList.remove(0);
            sortedList.remove(0);
            expect(() =>sortedList.get(0)).throw(Error);
        });
    });
    describe('sort()', function () {
        it('should sort with negative numbers', function () {
            sortedList.add(3);
            sortedList.add(-1);
            sortedList.add(-5);
            sortedList.add(3);
            sortedList.add(0);
            expect(sortedList.list.join(' ')).to.equal('-5 -1 0 3 3');
        });
        it('should sort with floating-point numbers', function () {
            sortedList.add(1.5);
            sortedList.add(-1);
            sortedList.add(-5);
            sortedList.add(-3.2);
            sortedList.add(0);
            sortedList.remove(0);
            expect(sortedList.list.join(' ')).to.equal('-3.2 -1 0 1.5');
        });
    })
});