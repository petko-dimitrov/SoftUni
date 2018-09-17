(async () => {
    let data = await $.get('./data.json');
    let contactsTemp = await $.get('./templates/contacts.hbs');
    let contactsHtml = Handlebars.compile(contactsTemp);
    let finalData = {contacts: data};
    let result = contactsHtml(finalData);
    $("#list").empty().append(result);

    let detailsTemp = await $.get('./templates/details.hbs');
    let detailsHtml = Handlebars.compile(detailsTemp);
    $('div.contact').on('click', function () {
        $('.content > div').removeClass('currentContact');
        $(this).addClass('currentContact');
        let index = $(this).attr('data-id');
        let detailsResult = detailsHtml(data[index]);
        $('#details > div').remove();
        $('#details').append(detailsResult);
    });
})();