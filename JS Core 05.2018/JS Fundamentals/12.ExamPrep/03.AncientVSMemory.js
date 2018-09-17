function solve(arr) {
    let input = arr.join(' ');
    let regex = /32656 19759 32763 0 ([0-9]+) (0 )+([0-9]+)/g;
    let match;
    let numbers = input.split(' ');

    while (match = regex.exec(input)) {
        let length = Number(match[1]);
        let startNumber = match[3];
        let startIndex = Number(numbers.indexOf(startNumber));
        let result = '';

        for (let i = startIndex; i < startIndex + length; i++) {
            result += String.fromCharCode(numbers[i]);
        }

        console.log(result);
    }
}

solve(['32656 19759 32763 0 5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0',
    '0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0']);