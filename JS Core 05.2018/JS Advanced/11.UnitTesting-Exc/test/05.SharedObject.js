const expect = require('chai').expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML = `<div id="wrapper">
    <input type="text" id="name">
    <input type="text" id="income">
    </div>`;

let sharedObject = {
    name: null,
    income: null,
    changeName: function (name) {
        if (name.length === 0) {
            return;
        }
        this.name = name;
        let newName = $('#name');
        newName.val(this.name);
    },
    changeIncome: function (income) {
        if (!Number.isInteger(income) || income <= 0) {
            return;
        }
        this.income = income;
        let newIncome = $('#income');
        newIncome.val(this.income);
    },
    updateName: function () {
        let newName = $('#name').val();
        if (newName.length === 0) {
            return;
        }
        this.name = newName;
    },
    updateIncome: function () {
        let newIncome = $('#income').val();
        if (isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) <= 0) {
            return;
        }
        this.income = Number(newIncome);
    }
};

describe("sharedObject", function () {
    describe("Name and income", function () {
        it("Name should start with value null", function () {
            expect(sharedObject.name).to.equal(null);
        });
        it("Income should start with value null", function () {
            expect(sharedObject.income).to.equal(null);
        });
    });
    describe("changeName", function () {
        it("Argument should not be an empty string", function () {
            sharedObject.changeName('');
            expect(sharedObject.name).to.equal(null);
        });
        it("Argument should not be an empty string", function () {
            $('#name').val('Gogo');
            sharedObject.changeName('');
            expect($('#name').val()).to.be.equal('Gogo');
        });
        it("Argument should not be an empty string with preexisting value", function () {
            sharedObject.changeName('Kiro');
            sharedObject.changeName('');
            expect(sharedObject.name).to.be.equal('Kiro');
            expect($("#name").val()).to.be.equal('Kiro');
        });
        it("Argument should not be an empty string with preexisting value", function () {
            sharedObject.name = 'Kiro';
            sharedObject.changeName('');
            expect(sharedObject.name).to.be.equal('Kiro');
            expect($("#name").val()).to.be.equal('Kiro');
        });
        it("changeName('Pesho') should return sharedObject.name = 'Pesho'", function () {
            sharedObject.changeName('Pesho');
            expect(sharedObject.name).to.be.equal('Pesho');
        });
        it("changeName('Pesho') should return #name value = 'Pesho'", function () {
            sharedObject.changeName('Pesho');
            expect($("#name").val()).to.be.equal('Pesho');
        });
        it("changeName('Pesho') should return sharedObject.name = 'Pesho'", function () {
            sharedObject.name = 'Kiro';
            sharedObject.changeName('Pesho');
            expect(sharedObject.name).to.be.equal('Pesho');
        });
        it("changeName('Pesho') should return #name value = 'Pesho'", function () {
            sharedObject.name = 'Kiro';
            sharedObject.changeName('Pesho');
            expect($("#name").val()).to.be.equal('Pesho');
        });
    });
    describe("changeIncome", function () {
        it("Argument should be a positive integer", function () {
            sharedObject.changeIncome('2');
            expect(sharedObject.income).to.be.equal(null);
        });
        it("Argument should not be an empty string", function () {
            sharedObject.changeIncome('');
            expect(sharedObject.income).to.be.equal(null);
        });
        it("Argument should be a positive integer", function () {
            sharedObject.changeIncome(-2);
            expect(sharedObject.income).to.be.equal(null);
        });
        it("Argument should be a positive integer with preexisting value", function () {
            sharedObject.income = 2;
            sharedObject.changeIncome(-2);
            expect(sharedObject.income).to.be.equal(2);
        });
        it("Argument should be a positive integer with preexisting value", function () {
            sharedObject.income = 2;
            sharedObject.changeIncome(0);
            expect(sharedObject.income).to.be.equal(2);
        });
        it("Argument should be a positive integer with preexisting value", function () {
            sharedObject.income = 2;
            sharedObject.changeIncome(2.3);
            expect(sharedObject.income).to.be.equal(2);
        });
        it("changeIncome(100) should return sharedObject.income = 100", function () {
            sharedObject.changeIncome(100);
            expect(sharedObject.income).to.be.equal(100);
        });
        it("changeIncome(100) should return sharedObject.income = 100", function () {
            sharedObject.income = 2;
            sharedObject.changeIncome(100);
            expect(sharedObject.income).to.be.equal(100);
        });
        it("changeIncome(100) should return #income value = 100", function () {
            sharedObject.income = 2;
            sharedObject.changeIncome(100);
            expect($('#income').val()).to.be.equal('100');
        });
    });
    describe("updateName", function () {
        it("If the name's textbox value is an empty string - no changes should be made", function () {
            $("#name").val('');
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('Pesho');
        });
        it("Should change the change sharedObject.name to Gosho", function () {
            sharedObject.changeName('Pesho');
            $("#name").val('Gosho');
            sharedObject.updateName();
            expect(sharedObject.name).to.be.equal('Gosho');
        });
    });
    describe("updateIncome", function () {
        it("If the income's textbox value is an empty string - no changes should be made", function () {
            sharedObject.income = 100;
            $("#income").val('');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(100);
        });
        it("If the income's textbox value cannot be parsed to positive number - no changes should be made", function () {
            sharedObject.income = 100;
            $("#income").val('Pesho');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(100);
        });
        it("If the income's textbox value cannot be parsed to positive number - no changes should be made", function () {
            sharedObject.income = 100;
            $("#income").val('-25');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(100);
        });
        it("If the income's textbox value cannot be parsed to positive number - no changes should be made", function () {
            sharedObject.income = 100;
            $("#income").val('0');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(100);
        });
        it("If the income's textbox value cannot be parsed to positive number - no changes should be made", function () {
            sharedObject.income = 100;
            $("#income").val('2.5');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(100);
        });
        it("Should change sharedObject.Income to 200", function () {
            sharedObject.income = 100;
            $("#income").val('200');
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(200);
        });
    });
});