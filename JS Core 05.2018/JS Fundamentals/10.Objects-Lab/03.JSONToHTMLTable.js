function solve(str) {
    let arr = JSON.parse(str);
    let keys = Object.keys(arr[0]);
    let result = '<table>\n  <tr>';

    for (let key of keys) {
        result += `<th>${key}</th>`
    }

    result += '</tr>\n';

    for (let obj of arr) {
        result += '  <tr>';
        for (let objKey in obj) {
            result += `<td>${htmlEscape(obj[objKey].toString())}</td>`
        }
        result += '</tr>\n'
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

solve('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'
);