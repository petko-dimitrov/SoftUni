function solve(arr) {
    let text = arr[0];
    let signsRegex = /\s*([.,!?:;]+)\s*/g;
    let numRegex = /\. (?=[0-9])/g;
    let quotesRegex = /"\s*(.+?)\s*"/g;
    let dotsRegex = /([.,!?:;]) (?=[.,!?:;])/g;

    text = text.replace(signsRegex, (match, g1) => `${g1} `);
    text = text.replace(numRegex, '.');
    text = text.replace(quotesRegex, (match, g1) => `"${g1}"`);
    text = text.replace(dotsRegex, (match, g1) => g1);
    console.log(text);

}

solve(["Terribly formatted text . With chaotic spacings.\" Terrible quoting \"! Also\n" +
"this date is pretty confusing : 20 . 12. 16 .\n"]);