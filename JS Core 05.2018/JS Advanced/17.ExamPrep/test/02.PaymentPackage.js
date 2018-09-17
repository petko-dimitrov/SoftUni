const expect = require('chai').expect;

class PaymentPackage {
    constructor(name, value) {
        this.name = name;
        this.value = value;
        this.VAT = 20;      // Default value
        this.active = true; // Default value
    }

    get name() {
        return this._name;
    }

    set name(newValue) {
        if (typeof newValue !== 'string') {
            throw new Error('Name must be a non-empty string');
        }
        if (newValue.length === 0) {
            throw new Error('Name must be a non-empty string');
        }
        this._name = newValue;
    }

    get value() {
        return this._value;
    }

    set value(newValue) {
        if (typeof newValue !== 'number') {
            throw new Error('Value must be a non-negative number');
        }
        if (newValue < 0) {
            throw new Error('Value must be a non-negative number');
        }
        this._value = newValue;
    }

    get VAT() {
        return this._VAT;
    }

    set VAT(newValue) {
        if (typeof newValue !== 'number') {
            throw new Error('VAT must be a non-negative number');
        }
        if (newValue < 0) {
            throw new Error('VAT must be a non-negative number');
        }
        this._VAT = newValue;
    }

    get active() {
        return this._active;
    }

    set active(newValue) {
        if (typeof newValue !== 'boolean') {
            throw new Error('Active status must be a boolean');
        }
        this._active = newValue;
    }

    toString() {
        const output = [
            `Package: ${this.name}` + (this.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${this.value}`,
            `- Value (VAT ${this.VAT}%): ${this.value * (1 + this.VAT / 100)}`
        ];
        return output.join('\n');
    }
}

describe('Test Payment package class', function () {
    it('Can be instantiated with two parameters', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(pack.name).to.be.equal('abv');
    });
    it('Can be instantiated with two parameters', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(pack.value).to.be.equal(100);
    });
    it('Should get the initial value of VAT', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(pack.VAT).to.be.equal(20);
    });
    it('Should get the initial value of active', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(pack.active).to.be.equal(true);
    });
    it('Should throw error with empty string as name', function () {
        expect(() => new PaymentPackage('', 100)).throw(Error);
    });
    it('Should throw error with only one parameter', function () {
        expect(() => new PaymentPackage('da')).throw(Error);
    });
    it('Should throw error with non string first param', function () {
        expect(() => new PaymentPackage(100, 100)).throw(Error);
    });
    it('Should throw error with negative number as value', function () {
        expect(() => new PaymentPackage('fd', -1)).throw(Error);
    });
    it('Should throw error with non number second param', function () {
        expect(() => new PaymentPackage('b', '100')).throw(Error);
    });
    it('Should throw error with negative number as VAT', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(() => pack.VAT = -10).throw(Error);
    });
    it('Should throw error with non number as VAT', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(() => pack.VAT = '20').throw(Error);
    });
    it('Should change VAT to 30', function () {
        let pack = new PaymentPackage('abv', 100);
        pack.VAT = 30;
        expect(pack.VAT).to.be.equal(30);
    });
    it('Should change active to false', function () {
        let pack = new PaymentPackage('abv', 100);
        pack.active = false;
        expect(pack.active).to.be.equal(false);
    });
    it('Should throw error with non boolean as active', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(() => pack.active = '20').throw(Error);
    });
    it('Should throw error with non boolean as active', function () {
        let pack = new PaymentPackage('abv', 100);
        expect(() => pack.active = null).throw(Error);
    });
    it('Should print the instance of the PaymentPackage', function () {
        let pack = new PaymentPackage('abv', 100);
        let result = 'Package: abv\n';
        result += '- Value (excl. VAT): 100\n';
        result += '- Value (VAT 20%): 120';
        expect(pack.toString()).to.be.equal(result);
    });
    it('Should print the instance of the PaymentPackage and add inactive', function () {
        let pack = new PaymentPackage('abv', 100);
        pack.active = false;
        let result = 'Package: abv (inactive)\n';
        result += '- Value (excl. VAT): 100\n';
        result += '- Value (VAT 20%): 120';
        expect(pack.toString()).to.be.equal(result);
    });
    it('Should print an array of PaymentPackages', function () {
        const packages = [
            new PaymentPackage('HR Services', 1500),
            new PaymentPackage('Consultation', 800),
            new PaymentPackage('Partnership Fee', 7000),
        ];
        let print = packages.join('\n');
        let result = 'Package: HR Services\n';
        result += '- Value (excl. VAT): 1500\n';
        result += '- Value (VAT 20%): 1800\n';
        result += 'Package: Consultation\n';
        result += '- Value (excl. VAT): 800\n';
        result += '- Value (VAT 20%): 960\n';
        result += 'Package: Partnership Fee\n';
        result += '- Value (excl. VAT): 7000\n';
        result += '- Value (VAT 20%): 8400';
        expect(print).to.be.equal(result);
    });
});