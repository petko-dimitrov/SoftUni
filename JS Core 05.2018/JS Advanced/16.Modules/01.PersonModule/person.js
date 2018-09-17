class Person {
    constructor(name) {
        this.name = name;
    }

    toString() {
        return `I'm ${this.name}`
    }
}

module.exports = Person;

//With AMD

// define([], function () {
//     class Person {
//         constructor(name) {
//             this.name = name;
//         }
//
//         toString() {
//             return `I'm ${this.name}`
//         }
//     }
//
//     return {Person};
// });