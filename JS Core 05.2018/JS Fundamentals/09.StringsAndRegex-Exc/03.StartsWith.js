function solve(str, start) {
    if (str.indexOf(start) === 0) {
        console.log(true);
    } else {
        console.log(false);
    }
}

solve('How have you been?', 'How');