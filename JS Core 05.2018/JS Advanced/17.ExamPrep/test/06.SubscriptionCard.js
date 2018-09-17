const expect = require('chai').expect;

class SubscriptionCard {
    constructor(firstName, lastName, SSN) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._SSN = SSN;
        this._subscriptions = [];
        this._blocked = false;
    }

    get firstName() {
        return this._firstName;
    }

    get lastName() {
        return this._lastName;
    }

    get SSN() {
        return this._SSN;
    }

    get isBlocked() {
        return this._blocked;
    }

    addSubscription(line, startDate, endDate) {
        this._subscriptions.push({
            line,
            startDate,
            endDate
        });
    }

    isValid(line, date) {
        if (this.isBlocked) return false;
        return this._subscriptions.filter(s => s.line === line || s.line === '*')
            .filter(s => {
                return s.startDate <= date &&
                    s.endDate >= date;
            }).length > 0;
    }

    block() {
        this._blocked = true;
    }

    unblock() {
        this._blocked = false;
    }
}

describe("SubscriptionCard Class", function() {
    let card;
    beforeEach(function () {
        card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
    });

    describe("Instantiate and test getters", function () {
        it("Accessor firstName", function() {
            expect(card.firstName).to.equal('Pesho');
        });
        it("Accessor lastName", function() {
            expect(card.lastName).to.equal('Petrov');
        });
        it("Accessor SSN", function() {
            expect(card.SSN).to.equal('00000000');
        });
        it("Accessor isBlocked", function() {
            expect(card.isBlocked).to.equal(false);
        });
        it("firstName cannot be changed", function() {
            card.firstName = 'Gosho';
            expect(card.firstName).to.equal('Pesho');
        });
        it("lastName cannot be changed", function() {
            card.lastName = 'Goshov';
            expect(card.lastName).to.equal('Petrov');
        });
        it("SSN cannot be changed", function() {
            card.SSN = '12345';
            expect(card.SSN).to.equal('00000000');
        });
    });

    describe("Function addSubscription()", function () {
        it("Subscribtions array has no entries", function() {
            expect(card._subscriptions.length).to.equal(0);
        });
        it("Subscribtions array has one entry", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions.length).to.equal(1);
        });
        it("Subscribtions array has two entries", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            card.addSubscription('*', new Date('2018-05-25'), new Date('2018-06-24'));
            expect(card._subscriptions.length).to.equal(2);
        });
        it("The subscribtion's endDate is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].endDate.getDate()).to.equal(21);
        });
        it("The subscribtion's endDate month is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].endDate.getMonth()).to.equal(4);
        });
        it("The subscribtion's endDate year is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].endDate.getFullYear()).to.equal(2018);
        });
        it("The subscribtion's startDate is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].startDate.getDate()).to.equal(22);
        });
        it("The subscribtion's startDate month is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].startDate.getMonth()).to.equal(3);
        });
        it("The subscribtion's startDate year is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].endDate.getFullYear()).to.equal(2018);
        });
        it("The subscribtion's line is correct", function() {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            expect(card._subscriptions[0].line).to.equal('120');
        });
    });

    describe('Function isValid()', function () {
        beforeEach(function () {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
        });

        it("Should be valid", function() {
            let result = card.isValid('120', new Date('2018-04-26'));
            expect(result).to.equal(true);
        });
        it("Should be valid", function() {
            let result = card.isValid('120', new Date('2018-04-22'));
            expect(result).to.equal(true);
        });
        it("Should be valid", function() {
            let result = card.isValid('120', new Date('2018-05-21'));
            expect(result).to.equal(true);
        });
        it("Should be valid", function() {
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            let result = card.isValid('122', new Date('2018-04-26'));
            expect(result).to.equal(true);
        });
        it("Should not be valid when blocked", function() {
            card.block();
            let result = card.isValid('120', new Date('2018-04-26'));
            expect(result).to.equal(false);
        });
        it("Should not be valid with wrong line", function() {
            let result = card.isValid('122', new Date('2018-04-26'));
            expect(result).to.equal(false);
        });
        it("Should not be valid with wrong date", function() {
            let result = card.isValid('120', new Date('2017-04-26'));
            expect(result).to.equal(false);
        });
        it("Should not be valid with wrong date", function() {
            let result = card.isValid('120', new Date('2019-04-26'));
            expect(result).to.equal(false);
        });
    });

    describe('block and unblock functions', function () {
        it('should block the card', function () {
            card.block();
            expect(card.isBlocked).to.equal(true);
        });
        it('should unblock the card', function () {
            card.block();
            card.unblock();
            expect(card.isBlocked).to.equal(false);
        });
    });
});