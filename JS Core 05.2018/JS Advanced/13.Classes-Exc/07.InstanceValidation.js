class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.products = [];
    }

    get clientId() {
        return this._clientId;
    }

    set clientId(id) {
        let idRegex = /^[0-9]{6}$/;
        if (!idRegex.test(id)) {
            throw new TypeError('Client ID must be a 6-digit number');
        }

        return this._clientId = id;
    }

    get email() {
        return this._email;
    }

    set email(em) {
        let emailRegex = /^[0-9A-Za-z]+@[a-zA-Z.]+$/;
        if (!emailRegex.test(em)) {
            throw new TypeError('Invalid e-mail');
        }

        return this._email = em;
    }

    get firstName() {
        return this._firstName;
    }

    set firstName(name) {
        let nameLengthRegex = /^.{3,20}$/;
        let nameRegex = /^[A-Za-z]+$/;

        if (!nameLengthRegex.test(name)) {
            throw new TypeError('First name must be between 3 and 20 characters long')
        }

        if (!nameRegex.test(name)) {
            throw new TypeError('First name must contain only Latin characters')
        }

        return this._firstName = name;
    }

    get lastName() {
        return this._lastName;
    }

    set lastName(name) {
        let nameLengthRegex = /^.{3,20}$/;
        let nameRegex = /^[A-Za-z]+$/;

        if (!nameLengthRegex.test(name)) {
            throw new TypeError('Last name must be between 3 and 20 characters long')
        }

        if (!nameRegex.test(name)) {
            throw new TypeError('Last name must contain only Latin characters')
        }

        return this._lastName = name;
    }
}

let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov');
console.log(acc);