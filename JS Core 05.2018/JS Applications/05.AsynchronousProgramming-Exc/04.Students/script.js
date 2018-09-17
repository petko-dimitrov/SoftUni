function attachEvents() {
    const BASE_URL = 'https://baas.kinvey.com/appdata/';
    const APP_KEY = 'kid_BJXTsSi-e';
    const APP_SECRET = '447b8e7046f048039d95610c1b039390';
    const USER = 'guest';
    const PASS = 'guest';
    const AUTH_HEADERS = {'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)};
    const USER_HEADERS = {'Authorization': "Basic " + btoa(USER + ':' + PASS)};
    const TABLE = $("#results");

    load();

    $('.create').on('click', function () {
        let ID = $('input.id').val();
        let FirstName = Number($('input.firstName').val());
        let LastName = $('input.lastName').val();
        let FacultyNumber = $('input.facNum').val();
        let Grade = Number($('input.grade').val());

        $.ajax({
            method: 'POST',
            url: BASE_URL + APP_KEY + '/students',
            headers: USER_HEADERS,
            data: {
                'ID': ID,
                'FirstName': FirstName,
                'LastName': LastName,
                'FacultyNumber': FacultyNumber,
                'Grade': Grade
            }
        }).then(load)
            .catch(handleError);
    });

    function load() {
        $.ajax({
            method: 'GET',
            url: BASE_URL + APP_KEY + '/students',
            headers: USER_HEADERS
        }).then(displayStudents)
            .catch(handleError);
    }

    function displayStudents(res) {
        res.sort((a, b) => a.ID - b.ID);
        for (const student of res) {
            let tr = $('<tr>');
            tr.append(`<td>${student.ID}</td>`)
                .append(`<td>${student.FirstName}</td>`)
                .append(`<td>${student.LastName}</td>`)
                .append(`<td>${student.FacultyNumber}</td>`)
                .append(`<td>${student.Grade}</td>`);
            TABLE.append(tr);
        }
    }

    function handleError(err) {
        console.log(err);
    }
}