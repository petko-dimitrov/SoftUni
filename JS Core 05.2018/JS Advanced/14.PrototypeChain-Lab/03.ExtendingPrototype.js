function extendPrototype(cl) {
    cl.prototype.species = "Human";
    cl.prototype.toSpeciesString = function () {
         return `I am a ${this.species}. ` + this.toString();
    }
}

class Person {
    constructor(name, email) {
        this.name = name;
        this.email = email;
    }

    toString() {
        return `${this.constructor.name} (name: ${this.name}, email: ${this.email})`;
    }
}

let p = new Person('Pesho', 'p@fds.vf');
extendPrototype(Person);
console.log(p.toSpeciesString());