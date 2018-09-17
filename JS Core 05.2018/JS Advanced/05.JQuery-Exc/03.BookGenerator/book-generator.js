function createBook(selector, title, author, isbn) {

    let bookGenerator = (function () {
        let idCounter = 1;

        return function (selector, title, author, isbn) {
            let id = "book" + idCounter;
            let div = $(`<div id='${id}'>`);
            div.append(`<p class="title">${title}</p>`)
                .append(`<p class="author">${author}</p>`)
                .append(`<p class="isbn">${isbn}</p>`)
                .append("<button>Select</button>")
                .append("<button>Deselect</button>");

            $(selector).append(div);

            $("button:contains('Select')").on('click', function () {
                $(this).parent().css('border', '2px solid blue');
            });

            $("button:contains('Deselect')").on('click', function () {
                $(this).parent().css('border', '');
            });

            idCounter++;
        }
    } ());

    bookGenerator(selector, title, author, isbn);
}
