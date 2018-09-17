const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_H1UdsnrNX'
const APP_SECRET = 'ccea60a73246433989cf97fa7dd07e4a'
const AUTH_HEADERS = {'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)}
const BOOKS_PER_PAGE = 10

function loginUser() {
    let username = $('#formLogin input[name="username"]').val();
    let password = $('#formLogin input[name="passwd"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/login',
        headers: AUTH_HEADERS,
        data: {username, password}
    }).then(function (res) {
        signInUser(res, 'Logout successful!')
    })
        .catch(handleAjaxError);
    // POST -> BASE_URL + 'user/' + APP_KEY + '/login'
    // signInUser(res, 'Login successful.')
}

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
        .catch(handleAjaxError)

    // POST -> BASE_URL + 'user/' + APP_KEY + '/'
    // signInUser(res, 'Registration successful.')
}

function listBooks() {
    showView('viewBooks');

    $.ajax({
        method: 'GET',
        url: BASE_URL + 'appdata/' + APP_KEY + '/books',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        displayPaginationAndBooks(res.reverse());
    }).catch(handleAjaxError)
    // GET -> BASE_URL + 'appdata/' + APP_KEY + '/books'
    // displayPaginationAndBooks(res.reverse())
}


function createBook() {
    let title = $('#formCreateBook input[name="title"]').val();
    let author = $('#formCreateBook input[name="author"]').val();
    let description = $('#formCreateBook textarea[name="description"]').val();

    $.ajax({
        method: 'POST',
        url: BASE_URL + 'appdata/' + APP_KEY + '/books',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')},
        data: {title, author, description}
    }).then(function (res) {
        listBooks();
        showInfo('Book created.');
    }).catch(handleAjaxError);
    // POST -> BASE_URL + 'appdata/' + APP_KEY + '/books'
    // showInfo('Book created.')
}

function deleteBook(book) {
    $.ajax({
        method: 'DELETE',
        url: BASE_URL + 'appdata/' + APP_KEY + '/books/' + book._id,
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function () {
        listBooks();
        showInfo('Book deleted.');
    }).catch(handleAjaxError)
    // DELETE -> BASE_URL + 'appdata/' + APP_KEY + '/books/' + book._id
    // showInfo('Book deleted.')
}

function loadBookForEdit(book) {
    showView('viewEditBook');
    $('#viewEditBook input[name="id"]').val(book._id);
    $('#viewEditBook input[name="title"]').val(book.title);
    $('#viewEditBook input[name="author"]').val(book.author);
    $('#viewEditBook textarea[name="description"]').val(book.description);
}

function editBook() {
    let id = $('#viewEditBook input[name="id"]').val();
    let title = $('#viewEditBook input[name="title"]').val();
    let author = $('#viewEditBook input[name="author"]').val();
    let description = $('#viewEditBook textarea[name="description"]').val();

    $.ajax({
        method: 'PUT',
        url: BASE_URL + 'appdata/' + APP_KEY + '/books/' + id,
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')},
        data: {title, author, description}
    }).then(function () {
        listBooks();
        showInfo('Book edited.')
    }).catch(handleAjaxError)

    // PUT -> BASE_URL + 'appdata/' + APP_KEY + '/books/' + book._id
    // showInfo('Book edited.')
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

function logoutUser() {
    $.ajax({
        method: 'POST',
        url: BASE_URL + 'user/' + APP_KEY + '/_logout',
        headers: {'Authorization': "Kinvey " + sessionStorage.getItem('authToken')}
    }).then(function (res) {
        sessionStorage.clear();
        showHideMenuLinks();
        showHomeView()
        $('#loggedInUser').text('');
        showInfo('Logout successful.');
    }).catch(handleAjaxError)
}

function signInUser(res, message) {
    saveAuthInSession(res);
    showHideMenuLinks();
    listBooks();
    showInfo(message)
}

function displayPaginationAndBooks(books) {
    let pagination = $('#pagination-demo')
    if (pagination.data("twbs-pagination")) {
        pagination.twbsPagination('destroy')
    }
    pagination.twbsPagination({
        totalPages: Math.ceil(books.length / BOOKS_PER_PAGE),
        visiblePages: 5,
        next: 'Next',
        prev: 'Prev',
        onPageClick: function (event, page) {
            $('#books > table tr').each((index, element) => {
                if (index > 0) {
                    $(element).remove()
                }
            });
            let startBook = (page - 1) * BOOKS_PER_PAGE
            let endBook = Math.min(startBook + BOOKS_PER_PAGE, books.length)
            $(`a:contains(${page})`).addClass('active')
            for (let i = startBook; i < endBook; i++) {
                let bookTr = $('<tr>').append(`<td>${books[i].title}</td>
								<td>${books[i].author}</td>
								<td>${books[i].description}</td>`);

                if (books[i]._acl.creator === sessionStorage.getItem('userId')) {
                    let actionsTd = $('<td>');
                    let editBtn = $('<a href="#">[Edit]</a>').on('click', function () {
                        loadBookForEdit(books[i]);
                    });
                    let deleteBtn = $('<a href="#">[Delete]</a>').on('click', function () {
                        deleteBook(books[i]);
                    });
                    actionsTd.append(editBtn)
                        .append(deleteBtn);
                    bookTr.append(actionsTd);
                }
                $('#books > table').append(bookTr);
            }
        }
    })
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}