class PublicTransportTable {
    constructor(town) {
        this.town = town;
        this.setCaption();
        this.addEventListeners();
    }

    addEventListeners() {


        $('.search-btn').on('click', function () {
            let nameInput = $('input[name="name"]');
            let typeInput = $('input[name="type"]');
            let name = nameInput.val();
            let type = typeInput.val();
            let rows = $('.vehicles-info').children().not('.more-info');

            if (name || type) {
                for (let i = 0; i < rows.length; i++) {
                    let nameTd = $(rows[i]).find('td').eq(1);
                    let typeTd = $(rows[i]).find('td').eq(0);

                    if (!nameTd.text().includes(name) || !typeTd.text().includes(type)) {
                        $(rows[i]).css('display', 'none');
                        let btn = $(rows[i]).find('td').eq(2).find('button');
                        if ($(btn).text() === 'Less Info') {
                            $(btn).click();
                        }
                    } else {
                        $(rows[i]).css('display', '');
                    }
                }
            }
        });

        $('.clear-btn').on('click', function () {
            let nameInput = $('input[name="name"]');
            let typeInput = $('input[name="type"]');
            let name = nameInput.val();
            let type = typeInput.val();
            let rows = $('.vehicles-info').children();

            for (let i = 0; i < rows.length; i++) {
                $(rows[i]).css('display', '');
            }

            name = nameInput.val('');
            type = typeInput.val('');
        });
    }

    setCaption() {
        $('caption').text(`${this.town}'s Public Transport`);
    }

    addVehicle(obj) {
        let mainInfoRow = $('<tr>');
        mainInfoRow.append(`<td>${obj.type}</td>`);
        mainInfoRow.append(`<td>${obj.name}</td>`);
        let btnTd = $('<td>');
        let moreLessBtn = $('<button>More Info</button>').on('click', function () {
            if ($(this).text() === 'More Info') {
                $(this).text('Less Info');
                let moreInfoRow = $('<tr class="more-info">');
                let moreInfoTd = $('<td colspan="3">');
                let moreInfoTable = $('<table>');
                let tbody = $('<tbody>');
                tbody
                    .append(`<tr><td>Route: ${obj.route}</td></tr>`)
                    .append(`<tr><td>Price: ${obj.price}</td></tr>`)
                    .append(`<tr><td>Driver: ${obj.driver}</td></tr>`);
                moreInfoTable.append(tbody);
                moreInfoTd.append(moreInfoTable);
                moreInfoRow.append(moreInfoTd);

                $(this).parent().parent()
                    .after(moreInfoRow);
            } else {
                $(this).text('More Info');
                $(this).parent().parent().next().remove();
            }
        });
        btnTd.append(moreLessBtn);
        mainInfoRow.append(btnTd);
        $('.vehicles-info').append(mainInfoRow);
    }
}