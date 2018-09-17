let Person = require('./person.js');

result.Person = Person;


//With AMD

// define(['./person'], function (person) {
//       return result.Person = Person;
// });