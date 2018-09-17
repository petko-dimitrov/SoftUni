function findLastDay(date) {
    let day = date[0];
    let month = date[1];
    let year = date[2];

    let currentDate = new Date(year, month - 1, day);
    let lastDay = new Date(currentDate.getFullYear(), currentDate.getMonth(), 0).getDate();

    console.log(lastDay);
}

findLastDay([17, 3, 2000]);