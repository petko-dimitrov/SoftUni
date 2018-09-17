function addSticker() {
    let title = $('.title');
    let content = $('.content');
    let list = $('#sticker-list');

    if (title.val() && content.val()) {
        let li = $('<li class="note-content">');
        li.append('<a class="button">x</a>').on('click', function () {
            li.remove();
        });
        li.append(`<h2>${title.val()}</h2>`)
            .append('<hr>')
            .append(`<p>${content.val()}</p>`);
        list.append(li);
        title.val('');
        content.val('');
    }
}