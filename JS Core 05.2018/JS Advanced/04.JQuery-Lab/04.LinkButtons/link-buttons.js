function attachEvents() {
    $('.button').on('click', buttonClick);

    function buttonClick() {
        $('.selected').removeClass('selected');
        $(this).addClass('selected');
    }
}