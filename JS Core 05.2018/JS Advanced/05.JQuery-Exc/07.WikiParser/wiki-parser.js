function wikiParser(selector) {
    let italicsRegex = /'{2}([^'=\[\]\|]+)'{2}/gm;
    let boldRegex = /'{3}([^'=\[\]\|]+)'{3}/gm;
    let h1Regex = /=([^'=\[\]\|]+)=/gm;
    let h2Regex = /={2}([^'=\[\]\|]+)={2}/gm;
    let h3Regex = /={3}([^'=\[\]\|]+)={3}/gm;
    let linkRegex = /\[{2}([^'=\[\]\|]+)\]{2}/gm;
    let pipedLinkRegex = /\[{2}([^'=\[\]]+)\]{2}/gm;

    let text = $(selector).text();

    let matches = boldRegex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<b>${matches[1]}</b>`);
        matches = boldRegex.exec(text);
    }

    matches = italicsRegex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<i>${matches[1]}</i>`);
        matches = italicsRegex.exec(text);
    }

    matches = h3Regex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<h3>${matches[1]}</h3>`);
        matches = h3Regex.exec(text);
    }

    matches = h2Regex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<h2>${matches[1]}</h2>`);
        matches = h2Regex.exec(text);
    }

    matches = h1Regex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<h1>${matches[1]}</h1>`);
        matches = h1Regex.exec(text);
    }

    matches = linkRegex.exec(text);
    while (matches) {
        text = text.replace(matches[0], `<a href="/wiki/${matches[1]}">${matches[1]}</a>`);
        matches = linkRegex.exec(text);
    }

    matches = pipedLinkRegex.exec(text);
    while (matches) {
        let linkInfo = matches[1].split('|');
        let href = linkInfo[0];
        let linkText = linkInfo[1];
        text = text.replace(matches[0], `<a href="/wiki/${href}">${linkText}</a>`);
        matches = pipedLinkRegex.exec(text);
    }

    $(selector).html(text);
}