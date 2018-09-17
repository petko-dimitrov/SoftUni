function getArticleGenerator(articles) {
    let div = $("#content");

    return function () {
        if (articles.length > 0) {
            let article = $("<article>");
            article.append(`<p>${articles.shift()}</p>`);
            div.append(article);
        }
    }
}