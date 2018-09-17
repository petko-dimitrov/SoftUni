function attachEvents() {
    $('#items').on('click', 'li', addAttr);
    
    function addAttr() {
        if ($(this).attr('data-selected')) {
            $(this).removeAttr('data-selected');
            $(this).css('background', '');
        } else {
            $(this).attr('data-selected', 'true');
            $(this).css('background', '#DDD');
        }
    }

    $('#showTownsButton').on('click', function () {
        let selected = $('#items li[data-selected=true]');
        selected = selected.toArray().map(x => x.textContent).join(', ');
       $('#selectedTowns').text(selected);
    });
}