function domSearch(selector, isCaseSensitive) {
    $(selector)
        .append("<div class ='add-controls'>")
        .append("<div class='search-controls'>")
        .append("<div class='result-controls'>");

    $(".add-controls")
        .append("<label>Enter text:</label>")
        .append("<input>")
        .append("<a href='#' class='button' style='display:inline-block;'>Add</a>");

    $(".search-controls")
        .append("<label>Search:</label>")
        .append("<input>");

    $(".result-controls")
        .append("<ul class='items-list'>");

    $("a:contains('Add')").on('click', function () {
        let input = $(".add-controls > input");

        if (input.val() !== '') {
            $(".items-list")
                .append($('<li>').addClass('list-item')
                    .append($('<a>').addClass('button').text('X').on('click', function () {
                        $(this).parent().remove()
                    }))
                    .append($('<strong>').text(input.val())));

            input.val('');
        }
    });

    $('.search-controls input').on('change', function () {
        let targetText = $(this).val();
        if (isCaseSensitive) {
            $(`.list-item:not(:contains(${targetText}))`).css('display', 'none');
        } else {
            targetText = targetText.toLowerCase();
            $('.list-item').toArray().forEach(e => {
                if (e.textContent.toLowerCase().indexOf(targetText) < 0) {
                    $(e).css('display', 'none');
                } else {
                    $(e).css('display', 'block');
                }
            })
        }
    })
}