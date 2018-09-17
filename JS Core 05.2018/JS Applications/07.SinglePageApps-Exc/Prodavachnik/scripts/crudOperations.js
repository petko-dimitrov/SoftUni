const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_SyOMWEwVQ';
const APP_SECRET = '83636952c5004134901ab50e5d41ac81';
const AUTH_HEADERS = {'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)};

function registerUser() {
    let username = $('#formRegister input[name="username"]').val();
    let password = $('#formRegister input[name="passwd"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/',
        headers: AUTH_HEADERS,
        data: {username, password}
    }).then(function (res) {
        signInUser(res, 'Registration successful!')
    })
        .catch(handleError)
}

function loginUser() {
    let username = $('#formLogin input[name="username"]').val();
    let password = $('#formLogin input[name="passwd"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: {username, password}
    }).then(function (res) {
        signInUser(res, 'Login successful!')
    })
        .catch(handleError);
}

function logoutUser() {
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/_logout',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        sessionStorage.clear();
        showHideMenuLinks();
        showHomeView();
        $('#loggedInUser').text('');
        showInfo('Logout successful.');
    }).catch(handleError)
}

function listAds() {
    showView('viewAds');

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        displayAds(res);
    }).catch(handleError)
}

function displayAds(res) {
    $('#ads > table tr').each((index, element) => {
        if (index > 0) {
            $(element).remove()
        }
    });
    for (const ad of res) {
        let tr = $('<tr>')
            .append(`<td>${ad.title}</td>`)
            .append(`<td>${ad.publisher}</td>`)
            .append(`<td>${ad.description}</td>`)
            .append(`<td>${ad.price}</td>`)
            .append(`<td>${ad.date}</td>`);
        let actionsTd = $('<td>');
        let readMoreBtn = $('<a href="#">[Read More]</a>').on('click', function () {
            loadReadMore(ad);
        });
        actionsTd.append(readMoreBtn);
        if (ad._acl.creator === sessionStorage.getItem('userId')) {
            let editBtn = $('<a href="#">[Edit]</a>').on('click', function () {
                loadAdForEdit(ad);
            });
            let deleteBtn = $('<a href="#">[Delete]</a>').on('click', function () {
                deleteAd(ad);
            });

            actionsTd.append(editBtn)
                .append(deleteBtn);
        }
        tr.append(actionsTd);
        $('#ads > table').append(tr);
    }

}

function createAd() {
    let title = $('#formCreateAd input[name="title"]').val();
    let description = $('#formCreateAd textarea[name="description"]').val();
    let publisher = sessionStorage.getItem('username');
    let date = $('#formCreateAd input[name="datePublished"]').val();
    let price = Number($('#formCreateAd input[name="price"]').val());
    let image =$('#formCreateAd input[name="image"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')},
        data: {
            'title': title,
            'description': description,
            'publisher': publisher,
            'date': date,
            'price': price.toFixed(2),
            'image': image
        }
    }).then(function (res) {
        listAds();
        showInfo('Ad created.');
    }).catch(handleError);
}

function loadAdForEdit(ad) {
    showView('viewEditAd');
    $('#formEditAd input[name="id"]').val(ad._id);
    $('#formEditAd input[name="publisher"]').val(ad.publisher);
    $('#formEditAd input[name="title"]').val(ad.title);
    $('#formEditAd textarea[name="description"]').val(ad.description);
    $('#formEditAd input[name="datePublished"]').val(ad.date);
    $('#formEditAd input[name="price"]').val(ad.price);
    $('#formEditAd input[name="image"]').val(ad.image);
}

function editAd() {
    let id = $('#formEditAd input[name="id"]').val();
    let publisher = $('#formEditAd input[name="publisher"]').val();
    let title = $('#formEditAd input[name="title"]').val();
    let description = $('#formEditAd textarea[name="description"]').val();
    let date = $('#formEditAd input[name="datePublished"]').val();
    let price = Number($('#formEditAd input[name=price]').val());
    let image = $('#formEditAd input[name="image"]').val();

    $.ajax({
        method: 'PUT',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements/' + id,
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')},
        data: {
            'title': title,
            'description': description,
            'publisher': publisher,
            'date': date,
            'price': price.toFixed(2),
            'image': image
        }
    }).then(function (res) {
        listAds();
        showInfo('Ad edited.')
    }).catch(handleError)
}

function deleteAd(ad) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements/' + ad._id,
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function () {
        listAds();
        showInfo('Ad deleted.');
    }).catch(handleError)
}

function loadReadMore(ad) {
    showView('viewReadMore');

    let backBtn = $('<a href="#">[Back]</a>').on('click', listAds);
    let div = $('<div id="more-info">')
        .append(`<h1>${ad.title}</h1>`)
        .append(`<div><img src="${ad.image}" height="250" width="250"/></div>`)
        .append(`<p><label><strong>Description: </strong></label>${ad.description}</p>`)
        .append(`<p><label><strong>Price: </strong></label>${ad.price}</p>`)
        .append(`<p><label><strong>Publisher: </strong></label>${ad.publisher}</p>`)
        .append(`<p><label><strong>Date: </strong></label>${ad.date}</p>`)
        .append(backBtn);

    $('#viewReadMore').empty()
        .append(div);
}

function saveAuthInSession(userInfo) {
    let userAuth = userInfo._kmd.authtoken;
    let userId = userInfo._id;
    let username = userInfo.username;
    sessionStorage.setItem('authToken', userAuth);
    sessionStorage.setItem('userId', userId);
    sessionStorage.setItem('username', username);
    $('#loggedInUser').text(`Hello ${username}!`);
}

function signInUser(res, message) {
    saveAuthInSession(res);
    showHideMenuLinks();
    listAds();
    showInfo(message);
}

function handleError(err) {
    let errorMsg = JSON.stringify(err);
    if (err.readyState === 0){
        errorMsg = "Cannot connect due to network error.";
    }
    if (err.responseJSON && err.responseJSON.description) {
        errorMsg = err.responseJSON.description;
    }
    showError(errorMsg)
}

