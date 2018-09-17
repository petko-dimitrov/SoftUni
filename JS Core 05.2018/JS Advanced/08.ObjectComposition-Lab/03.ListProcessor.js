function solve(arr) {
    let processor = (function () {
        let result = [];

        return {
            add: (str) => result.push(str),
            remove: (str) => result = result.filter(x => x !== str),
            print: () => console.log(result.join(','))
        }
    })();

    for (const element of arr) {
        let [command, str] = element.split(' ');
        processor[command](str);
    }
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);