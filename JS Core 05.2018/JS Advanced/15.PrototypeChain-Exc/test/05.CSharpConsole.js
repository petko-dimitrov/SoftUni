const expect = require('chai').expect;

class Console {

    static get placeholder() {
        return /{\d+}/g;
    }

    static writeLine() {
        let message = arguments[0];
        if (arguments.length === 1) {
            if (typeof (message) === 'object') {
                message = JSON.stringify(message);
                return message;
            }
            else if (typeof(message) === 'string') {
                return message;
            }
        }
        else {
            if (typeof (message) !== 'string') {
                throw new TypeError("No string format given!");
            }
            else {
                let tokens = message.match(this.placeholder).sort(function (a, b) {
                    a = Number(a.substring(1, a.length - 1));
                    b = Number(b.substring(1, b.length - 1));
                    return a - b;
                });
                if (tokens.length !== (arguments.length - 1)) {
                    throw new RangeError("Incorrect amount of parameters given!");
                }
                else {
                    for (let i = 0; i < tokens.length; i++) {
                        let number = Number(tokens[i].substring(1, tokens[i].length - 1));
                        if (number !== i) {
                            throw new RangeError("Incorrect placeholders given!");
                        }
                        else {
                            message = message.replace(tokens[i], arguments[i + 1])
                        }
                    }
                    return message;
                }
            }
        }
    }
}

describe('Test C# Console class', function () {
   describe('writeLine(string)', function () {
       it('Should return the input string', function () {
          let str = 'Pesho';
          let result = Console.writeLine(str);
          expect(result).to.be.equal(str);
       });
       it('Should return the input string', function () {
           let result = Console.writeLine('');
           expect(result).to.be.equal('');
       });
       it('should return undefined from a single number', () => {
           expect(Console.writeLine(5)).to.be.undefined;
       });
       it('should return "No string format given" ', () => {
           expect(() => Console.writeLine()).throw(TypeError)
       });
   });
    describe('writeLine(object)', function () {
        it('Should return the JSON representation of the object', function () {
            let obj = {'Pesho': 'e pich'};
            let result = Console.writeLine(obj);
            expect(result).to.be.equal(JSON.stringify(obj));
        });
    });
    describe('writeLine(templateString, parameters)', function () {
        it('Should throw a type error when first argument is not a string', function () {
            expect(() => Console.writeLine(6, 'str')).to.throw(TypeError);
        });
        it('Should throw a range error when the number of parameters does not correspond to the number of placeholders',
            function () {
            expect(() => Console.writeLine('{0} is {1}', 'Pesho', 'cool', 'dude')).to.throw(RangeError);
        });
        it('Should throw a range error when the number of parameters does not correspond to the number of placeholders',
            function () {
                expect(() => Console.writeLine('{1} is {2}', 'Pesho', 'cool')).to.throw(RangeError);
            });
        it('Should throw a range error when the number of placeholders exceeds the parameters',
            function () {
                expect(() => Console.writeLine('{0} is {1}', 'Pesho')).to.throw(RangeError);
            });
        it('Should throw a range error when the number of placeholders exceeds the parameters',
            function () {
                expect(() => Console.writeLine('{0} is {13}', 'Pesho', 'cool')).to.throw(RangeError);
            });
        it('Should throw a range error for equal placeholders',
            function () {
                expect(() => Console.writeLine('{0} is {0}', 'Pesho', 'cool')).to.throw(RangeError);
            });
        it('Should exchange the placeholders with the parameters',
            function () {
                let result = Console.writeLine('{0} is {1} {2}.', 'Pesho', 'cool', 'dude');
                expect(result).to.be.equal('Pesho is cool dude.')
            });
        it('Should exchange the placeholders with the parameters',
            function () {
                let result = Console.writeLine('{0} and {2} are {1}.', 'Pesho', 'cool', 'Gosho');
                expect(result).to.be.equal('Pesho and Gosho are cool.')
            });
        it('Should exchange the placeholders with the parameters',
            function () {
                let result = Console.writeLine('{0} is {1}.', 'Pesho', 31);
                expect(result).to.be.equal('Pesho is 31.')
            });
        it('Should exchange the placeholders with the parameters',
            function () {
                let result = Console.writeLine('{0}', 'Pesho');
                expect(result).to.be.equal('Pesho')
            });
    });
});