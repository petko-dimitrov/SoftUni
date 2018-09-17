function solve(arr) {
    let usernames = new Set();

    for (let name of arr) {
        usernames.add(name);
    }

    let sorted = Array.from(usernames)
        .sort((a, b) => {
            if (a.length < b.length) {
                return -1;
            } else if (a.length > b.length){
                return 1;
            } else {
                if (a < b) {
                    return -1;
                } else if (a > b) {
                    return 1;
                } else {
                    return 0;
                }
            }
        });

    for (let username of sorted) {
        console.log(username);
    }
}

solve(['Ashton', 'Kutcher', 'Ariel', 'Lilly', 'Keyden', 'Aizen', 'Billy', 'Braston']);