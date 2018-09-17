function composeTag(input) {
    let location = input[0];
    let altText = input[1];

    console.log(`<img src="${location}" alt="${altText}">`);
}

composeTag(['smiley.gif', 'Smiley Face']);