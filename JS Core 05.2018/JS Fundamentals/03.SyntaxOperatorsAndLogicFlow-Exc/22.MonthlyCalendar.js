function drawCalendar(input) {
    let [day, month, year] = input;

    let table = "<table>\n\t<tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>";

    let firstDay = new Date(year, month - 1, 2);
    let dayOfWeek = firstDay.getDay() - 1;
    let currentDay = 0;
    let lastDay = 7;

    if (dayOfWeek !== 0) {
        table += "\n\t<tr>";
        let prevMonthDays = new Date(year, month - 1, 0).getDate();

        for (let i = prevMonthDays - dayOfWeek + 1; i <= prevMonthDays; i++) {
            table += `<td class="prev-month">${i}</td>`;
        }

        for (let i = 1; i <= 7 - dayOfWeek ; i++) {
            if (i === day){
                table += `<td class="today">${i}</td>`;
            } else {
                table += `<td>${i}</td>`;
            }
            currentDay = i;
        }

        table += "</tr>";
    }

    currentDay++;

    while (currentDay <= new Date(year, month, 0).getDate()) {
        table += "\n\t<tr>";

        for (let col = 1; col <= 7; col++) {
            if (currentDay > new Date(year, month, 0).getDate()) {
                lastDay = col;
                break;
            }

            if (currentDay === day){
                table += `<td class="today">${currentDay}</td>`;
            } else {
                table += `<td>${currentDay}</td>`;
            }

            currentDay++;

            if (col === 7) {
                table += "</tr>";
            }
        }
    }

    for (let i = 1; i <= 8 - lastDay; i++) {
        table += `<td class="next-month">${i}</td>`;
    }

    table += "</tr>\n</table>";
    //return table;
    console.log(table);
}

drawCalendar([24, 12, 2012]);