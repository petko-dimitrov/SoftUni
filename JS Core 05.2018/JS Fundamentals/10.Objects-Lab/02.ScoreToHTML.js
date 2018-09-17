function solve(str) {
    let arr = JSON.parse(str);
    let result = '<table>\n  <tr><th>name</th><th>score</th></tr>\n';

    for (let obj of arr) {
        result += `  <tr><td>${htmlEscape(obj.name)}</td><td>${htmlEscape(obj['score'].toString())}</td></tr>\n`;
    }

    result += "</table>";
    console.log(result);

    function htmlEscape(str) {
        return str.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}

solve('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]');