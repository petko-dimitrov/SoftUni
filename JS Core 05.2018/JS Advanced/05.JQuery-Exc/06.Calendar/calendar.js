function calendar(arr) {
    let [day, month, year] = arr;
    let date = new Date(year, month - 1, day);
    let firstDay = new Date(year, month - 1, 1);
    const monthNames = ["January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"];
    let counter = 0;
    let totalDays = daysInMonth(month, year);

    $("#content").append("<table>");
    $("table")
        .append(`<caption>${monthNames[date.getMonth()]} ${year}</caption>`)
        .append("<tbody>");
    $("tbody").append("<tr>");
    $("tr").append("<th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th><th>Sun</th>");

    if (firstDay.getDay() === 0) {
        $("tbody").append("<tr>");
        for (let i = 0; i < 6; i++) {
            $("tr:eq(1)").append("<td></td>");
        }
        $("tr:eq(1)").append("<td>1</td>");
    } else {
        $("tbody").append("<tr>");
        for (let i = 0; i < firstDay.getDay() - 1; i++) {
            $("tr:eq(1)").append("<td></td>");
        }

        for (let i = 0; i <= 7 - firstDay.getDay(); i++) {
            if (i === day) {
                $("tr:eq(1)").append(`<td class="today">${i+1}</td>`);

            } else {
                $("tr:eq(1)").append(`<td>${i+1}</td>`);
            }
            counter = i+1;
        }
    }

    let row = 2;
    let fullRows = Math.floor((totalDays - counter) / 7);

    for (let i = 0; i < fullRows; i++) {
        $("tbody").append("<tr>");

        for (let j = 0; j < 7; j++) {
            counter++;
            if (counter === day) {
                $(`tr:eq(${row})`).append(`<td class="today">${counter}</td>`);
            } else {
                $(`tr:eq(${row})`).append(`<td>${counter}</td>`);
            }
        }

        row++;
    }

    if (counter < totalDays) {
        $("tbody").append("<tr>");
        for (let i = 0; i < 7; i++) {
            counter++;
            if (counter <= totalDays) {
                if (counter === day) {
                    $(`tr:eq(${row})`).append(`<td class="today">${counter}</td>`);
                } else {
                    $(`tr:eq(${row})`).append(`<td>${counter}</td>`);
                }
            } else {
                $(`tr:eq(${row})`).append(`<td></td>`);
            }
        }
    }

    function daysInMonth(month, year) {
        return new Date(year, month, 0).getDate();
    }
}