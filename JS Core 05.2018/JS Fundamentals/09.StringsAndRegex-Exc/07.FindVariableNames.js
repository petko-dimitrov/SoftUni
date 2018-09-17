function extractVariables(text) {
    let regex = /\b(_)(\w+)\b/g;
    let variables = [];
    let match;

    while (match = regex.exec(text)) {
        variables.push(match[2]);
    }

    console.log(variables.join(','));
}

extractVariables('The _id and _age variables are both integers.');