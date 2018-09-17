function solve(arr) {
    let result = '<table>\n';

    for (let line of arr) {
        let obj = JSON.parse(line);
        result += `  <tr>\n    <td>${htmlEscape(obj["name"])}</td>\n`;
        result += `    <td>${htmlEscape(obj["position"])}</td>\n`;
        result += `    <td>${htmlEscape(obj["salary"].toString())}</td>\n  <tr>\n`;
    }

    result += '</table>';
    console.log(result);

    function htmlEscape(str) {
        return str.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;');
    }
}

solve(['{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}']);