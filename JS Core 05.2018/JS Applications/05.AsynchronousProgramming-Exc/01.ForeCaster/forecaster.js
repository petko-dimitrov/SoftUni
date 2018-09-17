function attachEvents() {
    let locationsUrl = 'https://judgetests.firebaseio.com/locations.json';
    let currentUrl = 'https://judgetests.firebaseio.com/forecast/today/';
    let forecastUrl = 'https://judgetests.firebaseio.com/forecast/upcoming/';
    let input = $('#location');
    let icons = {
        'Sunny': '&#x2600;',
        'Partly sunny': '&#x26C5;',
        'Overcast': '&#x2601;',
        'Rain': '&#x2614;',
        'Degrees': '&#176;'
    };
    let gradsSymbol = icons['Degrees'];

    $('#submit').on('click', function () {
        var code = '';
        let city = input.val();
        $('#forecast').css('display', '');

        $.ajax({
            method: 'GET',
            url: locationsUrl
        }).then(function (res) {
            res = res.filter(x => x.name === city);
            code = res[0].code;
            $.ajax({
                method: 'GET',
                url: currentUrl + `${code}.json`
            }).then(printCurrent)
                .catch(handleError);

            $.ajax({
                method: 'GET',
                url: forecastUrl + `${code}.json`
            }).then(printForecast)
                .catch(handleError);
        }).catch(handleError);

        input.val('');
    });

    function printCurrent(current) {
        let condition = current.forecast.condition;
        let icon = icons[condition];
        let low = current.forecast.low;
        let high = current.forecast.high;
        let conditionSpan = $('<span class="condition">');
        conditionSpan
            .append(`<span class="forecast-data">${current.name}</span>`)
            .append(`<span class="forecast-data">${low}${gradsSymbol}/${high}${gradsSymbol}</span>`)
            .append(`<span class="forecast-data">${condition}</span>`);
        $('#current')
            .append(`<span class="condition symbol">${icon}</span>`)
            .append(conditionSpan);
    }

    function printForecast(forecast) {
        for (const day of forecast.forecast) {
            let condition = day.condition;
            let icon = icons[condition];
            let low = day.low;
            let high = day.high;

            let upcomingSpan = $('<span class="upcoming">')
                .append(`<span class="symbol">${icon}</span>`)
                .append(`<span class="forecast-data">${low}${gradsSymbol}/${high}${gradsSymbol}</span>`)
                .append(`<span class="forecast-data">${condition}</span>`);

            $('#upcoming').append(upcomingSpan);
        }
    }

    function handleError(err) {
        console.log(err);
        $('#forecast').text('Error');
    }
}