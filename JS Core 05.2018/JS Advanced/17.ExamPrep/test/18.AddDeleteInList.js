const expect = require('chai').expect;

let list = (function(){
    let data = [];
    return {
        add: function(item) {
            data.push(item);
        },
        delete: function(index) {
            if (Number.isInteger(index) && index >= 0 && index < data.length) {
                return data.splice(index, 1)[0];
            } else {
                return undefined;
            }
        },
        toString: function() {
            return data.join(", ");
        }
    };
})();

describe("List functions tests", function() {
    it("should be empty initially", function() {
        expect(list.toString()).to.equal('');
    });
    it("should have add, delete and toString functions", function() {
        expect(typeof list.add).to.equal('function');
        expect(typeof list.delete).to.equal('function');
        expect(typeof list.toString).to.equal('function');
    });
    it("add(item) – appends string to the end of the list", function() {
        list.add('pesho');
        expect(list.toString()).to.equal('pesho');
    });
    it("add(item) – appends number to the end of the list", function() {
        list.add(3);
        expect(list.toString()).to.equal('pesho, 3');
    });
    it('delete(index) – Returns the deleted item', function () {
        let result = list.delete(1);
        expect(result).to.equal(3);
    });
    it('delete(index) – Returns undefined with invalid index', function () {
        let result = list.delete(1);
        expect(result).to.equal(undefined);
        result = list.delete(-1);
        expect(result).to.equal(undefined);
        result = list.delete(1.2);
        expect(result).to.equal(undefined);
    });
    it('delete zero index', function () {
        let result = list.delete(0);
        expect(result).to.equal('pesho');
    });
    it('delete zero index with no data', function () {
        let result = list.delete(0);
        expect(result).to.equal(undefined);
    });
    it('toString() with no data', function () {
        expect(list.toString()).to.equal('');
    });
    it('toString() with mixed data', function () {
        list.add(3);
        list.add({'name': 'gogo'});
        list.add('kiro');
        expect(list.toString()).to.equal('3, [object Object], kiro');
    });
    it('delete(index) – Returns the deleted item', function () {
        let result = list.delete(2);
        expect(result).to.equal('kiro');
        result = list.delete(0);
        expect(result).to.equal(3)
    });
    it('delete(index) – Returns the deleted item', function () {
        list.delete(0);
        list.add(1);
        list.add(3);
        expect(list.delete(0)).to.equal(1);
        expect(list.delete(0)).to.equal(3);
        expect(list.toString()).to.equal('')
    });
});