function parseData(arr) {
    let regex = /^([A-Z][a-zA-Z]*) - ([1-9][\d]*) - ([A-Za-z0-9-\s]+)$/g;
    let match;

    for (let arrElement of arr) {
        while (match = regex.exec(arrElement)) {
            console.log(`Name: ${match[1]}`);
            console.log(`Position: ${match[3]}`);
            console.log(`Salary: ${match[2]}`);
        }
    }
}

parseData(['Isacc - 1000 - CEO',
    'Ivan - 500 - Employee',
    'Peter - 500 - Employee']
);