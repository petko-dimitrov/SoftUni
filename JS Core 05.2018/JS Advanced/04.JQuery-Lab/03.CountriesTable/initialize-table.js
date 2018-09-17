function initializeTable() {
    addCountry('Bulgaria', 'Sofia');
    addCountry('Germany', 'Berlin');
    addCountry('Russia', 'Moscow');
    fixButtons();
    $('#createLink').on('click', createCountry);

    function addCountry(country, capital) {
        let row = $('<tr>')
            .append($("<td>").text(country))
            .append($("<td>").text(capital))
            .append($("<td>")
                .append($("<a href='#'>[Up]</a>").on('click', moveUp))
                .append($("<a href='#'>[Down]</a>")
                    .on('click', moveDown))
                .append($("<a href='#'>[Delete]</a>")
                    .on('click', deleteRow)));
        row.css('display','none');
        $("#countriesTable").append(row);
        row.fadeIn();

    }

    function createCountry() {
        let country = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        addCountry(country, capital);
        $('#newCountryText').val('');
        $('#newCapitalText').val('');
        fixButtons();
    }

    function moveUp() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.insertBefore(row.prev());
            row.fadeIn();
            fixButtons();
        });
    }

    function moveDown() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.insertAfter(row.next());
            row.fadeIn();
            fixButtons();
        });
    }

    function deleteRow() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.remove();
            fixButtons();
        });
    }

    function fixButtons() {
        $('#countriesTable a').css('display', 'inline');
        let rows = $('#countriesTable tr');
        $(rows[2]).find("a:contains('Up')").css('display', 'none');
        $(rows[rows.length - 1]).find("a:contains('Down')").css('display', 'none');
    }
}