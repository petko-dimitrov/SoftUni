function attachEvents() {
    let townsInput = $('#towns');
    let source = $('#towns-template').html();
    let template = Handlebars.compile(source);

    $('#btnLoadTowns').on('click', function () {
        let townsAsStr = townsInput.val();

        if (townsAsStr) {
            let townsArr = townsAsStr.split(', ');
            let data = {towns: []};
            for (const town of townsArr) {
                let obj = {'name': town};
                data['towns'].push(obj)
            }

            let result = template(data);
            $("#root").empty()
                .append(result);
        }

        townsInput.val('');
    })
}