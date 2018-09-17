function filterByAge(minAge, person1Name, person1Age, person2Name, person2Age) {
    let firstPerson = {name: person1Name, age: person1Age};
    let secondPerson = {name: person2Name, age: person2Age};

    if (firstPerson.age >= minAge) {
        console.log(firstPerson);
    }

    if (secondPerson.age >= minAge) {
        console.log(secondPerson);
    }
}

filterByAge(12, 'Ivan', 15, 'Asen', 9);