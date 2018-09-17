function escape(arr) {
    let result = '<ul>\n';

    for (let arrElement of arr) {
        result +=`  <li>${htmlEscape(arrElement)}</li>\n`;
    }

    result += '</ul>';
    console.log(result);
    
    function htmlEscape(str) {
       return str .replace(/&/g, '&amp;')
           .replace(/</g, '&lt;')
           .replace(/>/g, '&gt;')
           .replace(/"/g, '&quot;');
    }
}

escape(['<b>unescaped text</b>', 'normal text']);