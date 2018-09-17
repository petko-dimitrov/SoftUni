function solve (text){
    let regex = /^<message((?:\s+[a-z]+="[A-Za-z0-9 .]+"\s*?)*)>((?:.|\n)+?)<\/message>$/gm;

    let match = regex.exec(text);
    if (!match) {
        console.log("Invalid message format");
        return;
    }

    let attRegex = /([a-z]+)="([A-Za-z0-9 .]+)/gm;
    let attributes = match[1];
    let message = match[2];
    let sender = '';
    let recipient ='';
    let attMatch = attRegex.exec(attributes);

    while (attMatch) {
        if (attMatch[1] === 'from') {
            sender = attMatch[2];
        } else if (attMatch[1] === 'to') {
            recipient = attMatch[2];
        }

        attMatch = attRegex.exec(attributes);
    }

    if (!sender || !recipient) {
        console.log('Missing attributes');
        return;
    }

    let paragraphs = message.split('\n');

    let result = '<article>\n';
    result += `  <div>From: <span class="sender">${sender}</span></div>\n`;
    result += `  <div>To: <span class="recipient">${recipient}</span></div>\n  <div>\n`;
    for (let p of paragraphs){
        result += `    <p>${p}</p>\n`;
    }
    result += `  </div>\n</article>`;

    console.log(result);
}

solve('<message to="Bob" from="Alice" timestamp="1497254092">Hey man, what\'s up?</message>\n');