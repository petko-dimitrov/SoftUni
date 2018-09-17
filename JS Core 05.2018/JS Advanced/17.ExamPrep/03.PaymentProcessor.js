class PaymentProcessor {
    constructor(options) {
        this.options = options;
        this.payments = {};
        this.balance = 0;

        if (this.options === undefined) {
            this.options = {
                types: ["service", "product", "other"],
                precision: 2
            }
        } else if (options.types === undefined) {
            this.options.types = ["service", "product", "other"];
        } else if (options.precision === undefined) {
            this.options.precision = 2;
        }
    }

    registerPayment(id, name, type, value) {
        if (this.payments.hasOwnProperty(id)) {
            throw new Error('Payment with this id already exists!');
        }
        if (typeof id !== 'string' || id.length < 1) {
            throw new Error('Id should be a non empty string!');
        }
        if (typeof name !== 'string' || name.length < 1) {
            throw new Error('Name should be a non empty string!');
        }
        if (!this.options.types.includes(type)) {
            throw new Error('There is no such type of payment!');
        }
        if (typeof value !== 'number' || value <= 0) {
            throw new Error('Value should be a positive number!')
        }

        this.payments[id] = {};
        this.payments[id]['name'] = name;
        this.payments[id]['type'] = type;
        this.payments[id]['value'] = value.toFixed(this.options.precision);
        this.balance += Number(value.toFixed(this.options.precision));
    }

    deletePayment(id) {
        if (!this.payments.hasOwnProperty(id)) {
            throw new Error('Cannot find payment with this id!');
        }
        delete this.payments[id];
    }

    get(id) {
        if (!this.payments.hasOwnProperty(id)) {
            throw new Error('Cannot find payment with this id!');
        }

        let result = `Details about payment ID: ${id}\n`;
        result += `- Name: ${this.payments[id].name}\n`;
        result += `- Type: ${this.payments[id].type}\n`;
        result += `- Value: ${this.payments[id].value}`;
        return result;
    }

    setOptions(options) {
        if (options.hasOwnProperty('types')) {
            this.options.types = options.types;
        }
        if (options.hasOwnProperty('precision')) {
            this.options.precision = options.precision;
        }
    }

    toString() {
        let result = `Summary:\n`;
        result += `- Payments: ${Object.keys(this.payments).length}\n`;
        result += `- Balance: ${this.balance.toFixed(this.options.precision)}`;
        return result;
    }
}

let p = new PaymentProcessor();
p.registerPayment('0001', 'Microchips', 'product', 15000);
p.registerPayment('01A3', 'Biopolymer', 'product', 23000);
console.log(p.toString());
