const BASE_URL = 'https://baas.kinvey.com/';
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
        showInfo('Logout successful.');
        sessionStorage.clear();
        showHeader();
        showHomeView();
    }).catch(handleError)
}

function listAds() {
    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        displayAds(res);
    }).catch(handleError)
}

function createAd() {
    let title = $('#formCreateAd input[name="title"]').val();
    let description = $('#formCreateAd textarea[name="description"]').val();
    let publisher = sessionStorage.getItem('username');
    let date = $('#formCreateAd input[name="datePublished"]').val();
    let price = Number($('#formCreateAd input[name="price"]').val());
    let image = $('#formCreateAd input[name="image"]').val();

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
        showInfo('Ad created.');
        listAds();
    }).catch(handleError);
}

async function loadAdForEdit(ad) {
    await showCreateEditView();
    $('#formEditAd input[name="id"]').val(ad._id);
    $('#formEditAd input[name="title"]').val(ad.title);
    $('#formEditAd textarea[name="description"]').val(ad.description);
    $('#formEditAd input[name="datePublished"]').val(ad.date);
    $('#formEditAd input[name="price"]').val(ad.price);
    $('#formEditAd input[name="image"]').val(ad.image);
    $('#buttonEditAd').on('click', editAd);
}

function editAd() {
    let id = $('#formEditAd input[name="id"]').val();
    let publisher = sessionStorage.getItem('username');
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
        showInfo('Ad edited.');
        listAds();
    }).catch(handleError)
}

function deleteAd(ad) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/advertisements/' + ad._id,
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function () {
        showInfo('Ad deleted.');
        listAds();
    }).catch(handleError)
}

function saveAuthInSession(userInfo) {
    let userAuth = userInfo._kmd.authtoken;
    let userId = userInfo._id;
    let username = userInfo.username;
    sessionStorage.setItem('authToken', userAuth);
    sessionStorage.setItem('userId', userId);
    sessionStorage.setItem('username', username);
}

function signInUser(res, message) {
    saveAuthInSession(res);
    showHeader();
    showInfo(message);
    listAds();
}

function handleError(err) {
    let errorMsg = JSON.stringify(err);
    if (err.readyState === 0) {
        errorMsg = "Cannot connect due to network error.";
    }
    if (err.responseJSON && err.responseJSON.description) {
        errorMsg = err.responseJSON.description;
    }
    showError(errorMsg)
}