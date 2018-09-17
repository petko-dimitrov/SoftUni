function findNumbers(arr) {
    let regex = /[\d]+/g;
    let text = arr.join();
    let numbers = text.match(regex);
    console.log(numbers.join(' '));
}

findNumbers(['The300',
    'What is that?',
    'I think it’s the 3rd movie.',
    'Lets watch it at 22:45']);