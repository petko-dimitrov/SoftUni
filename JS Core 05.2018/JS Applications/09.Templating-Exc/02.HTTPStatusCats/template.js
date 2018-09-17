$(() => {
    renderCatTemplate();

    function renderCatTemplate() {
        let source = $('#cat-template').html();
        let template = Handlebars.compile(source);
        let context = {'statusCats': cats};
        let result = template(context);
        $('#allCats').append(result);

        $('.btn').on('click', function () {
            if ($(this).text() === 'Show status code') {
                $(this).text('Hide status code');
            } else {
                $(this).text('Show status code')
            }
            let div = $(this).parent().find('div');
            div.toggle();
        })
    }

});
