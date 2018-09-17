function printNumbers(num) {
    let result = "<ul>\n";
    let color = "";

    for (let i = 1; i <= num; i++) {
        if(i % 2 === 0){
            color = "blue";
        } else {
            color = "green";
        }
        result += `  <li><span style='color:${color}'>${i}</span></li>\n`;
    }

    result += "</ul>";
    console.log(result);
}

printNumbers(10);