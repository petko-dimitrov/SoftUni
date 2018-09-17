const expect = require('chai').expect;

class StringBuilder {
    constructor(string) {
        if (string !== undefined) {
            StringBuilder._vrfyParam(string);
            this._stringArray = Array.from(string);
        } else {
            this._stringArray = [];
        }
    }

    append(string) {
        StringBuilder._vrfyParam(string);
        for (let i = 0; i < string.length; i++) {
            this._stringArray.push(string[i]);
        }
    }

    prepend(string) {
        StringBuilder._vrfyParam(string);
        for (let i = string.length - 1; i >= 0; i--) {
            this._stringArray.unshift(string[i]);
        }
    }

    insertAt(string, startIndex) {
        StringBuilder._vrfyParam(string);
        this._stringArray.splice(startIndex, 0, ...string);
    }

    remove(startIndex, length) {
        this._stringArray.splice(startIndex, length);
    }

    static _vrfyParam(param) {
        if (typeof param !== 'string') throw new TypeError('Argument must be string');
    }

    toString() {
        return this._stringArray.join('');
    }
}

describe("StringBuilder class tests", function () {
    describe('Constructor tests', function () {
        it('Can be instantiated without anything', function () {
            let str = new StringBuilder();
            expect(str.toString()).to.equal('');
        });
        it('Can be instantiated without anything', function () {
            let str = new StringBuilder();
            str.append('pesho');
            expect(str.toString()).to.equal('pesho');
        });
        it('Can be instantiated without anything', function () {
            let str = new StringBuilder();
            str.prepend('pesho');
            expect(str.toString()).to.equal('pesho');
        });
        it('Can be instantiated without anything', function () {
            let str = new StringBuilder();
            str.insertAt('pesho', 4);
            expect(str.toString()).to.equal('pesho');
        });
        it('Can be instantiated with a passed in string argument', function () {
            let str = new StringBuilder('hello');
            expect(str.toString()).to.equal('hello');
        });
        it('Cannot be instantiated with a passed in non-string argument', function () {
            expect(() => new StringBuilder(12)).throw('Argument must be string');
        });
        it('Cannot be instantiated with a passed in non-string argument', function () {
            expect(() => new StringBuilder(['pesho'])).throw('Argument must be string');
        });
    });

    describe('Function append(string)', function () {
        let str;
        beforeEach(function () {
            str = new StringBuilder('hello');
        });

        it('should add the input string to the end', function () {
            str.append(' world');
            expect(str.toString()).to.equal('hello world')
        });
        it('should add the input string to the end with empty string', function () {
            str.append('');
            expect(str.toString()).to.equal('hello')
        });
        it('should throw error with non-string input', function () {
            expect(() => str.append(47)).throw('Argument must be string');
        });
    });

    describe('Function prepend(string)', function () {
        let str;
        beforeEach(function () {
            str = new StringBuilder('hello');
        });

        it('should add the input string to the beginning', function () {
            str.prepend('world ');
            expect(str.toString()).to.equal('world hello')
        });
        it('should add the input string to the beginning with empty string', function () {
            str.prepend('');
            expect(str.toString()).to.equal('hello')
        });
        it('should throw error with non-string input', function () {
            expect(() => str.prepend(47)).throw('Argument must be string');
        });
    });

    describe('insertAt(string, index)', function () {
        let str;
        beforeEach(function () {
            str = new StringBuilder('hello');
        });

        it('should insert the input string at the given index', function () {
            str.insertAt('world ', 0);
            expect(str.toString()).to.equal('world hello')
        });
        it('should insert the input string at the given index', function () {
            str.insertAt('world ', -1);
            expect(str.toString()).to.equal('hellworld o')
        });
        it('should insert the input string at the given index', function () {
            str.insertAt('world', 5);
            expect(str.toString()).to.equal('helloworld')
        });
        it('should insert the input string at the given index', function () {
            str.insertAt('world', 15);
            expect(str.toString()).to.equal('helloworld')
        });
        it('should insert the input string at the given index', function () {
            str.insertAt('world', 2);
            expect(str.toString()).to.equal('heworldllo')
        });
        it('should insert the input string at the given index with empty string', function () {
            str.insertAt('', 3);
            expect(str.toString()).to.equal('hello')
        });
        it('should throw error with non-string input', function () {
            expect(() => str.insertAt(47, 3)).throw('Argument must be string');
        });
        it('should throw error with non-string input', function () {
            expect(() => str.insertAt(['kiro'], 3)).throw('Argument must be string');
        });
    });

    describe('Function remove(startIndex, length)', function () {
        let str;
        beforeEach(function () {
            str = new StringBuilder('hello');
        });

        it('should remove the given range of symbols', function () {
            str.remove(0, 1);
            expect(str.toString()).to.equal('ello')
        });
        it('should remove the given range of symbols', function () {
            str.remove(-3, 1);
            expect(str.toString()).to.equal('helo')
        });
        it('should remove the given range of symbols', function () {
            str.remove(0, -2);
            expect(str.toString()).to.equal('hello')
        });
        it('should remove the given range of symbols', function () {
            str.remove(1, 4);
            expect(str.toString()).to.equal('h')
        });
        it('should remove the given range of symbols', function () {
            str.remove(3, 5);
            expect(str.toString()).to.equal('hel')
        });
        it('should remove the given range of symbols', function () {
            str.remove(0, 10);
            expect(str.toString()).to.equal('')
        });
        it('should remove the given range of symbols', function () {
            str.remove(0, 5);
            expect(str.toString()).to.equal('')
        });
    });

    describe('Array and properties tests', function () {
        let str;
        beforeEach(function () {
            str = new StringBuilder('hello');
        });

        it('must initialize data to an array', function () {
            expect(str._stringArray instanceof Array).to.equal(true);
            expect(str._stringArray.length).to.equal(5);
        });

        it('_vrfyParam(param) should be static', function () {
            expect(Object.getPrototypeOf(str).hasOwnProperty('_vrfyParam')).to.equal(false);
        });
    })
});