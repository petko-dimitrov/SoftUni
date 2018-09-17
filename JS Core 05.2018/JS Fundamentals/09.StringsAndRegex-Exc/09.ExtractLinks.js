function extractLinks(arr) {
    let regex = /(w{3})\.([a-zA-Z0-9-]+)(\.[a-z]+)+/g;
    let text = arr.join();
    let links = text.match(regex);
    if (links){
        console.log(links.join('\n'));
    }
}

extractLinks(['Join WebStars now for free, at web-stars.com',
'You can also support our partners:']);