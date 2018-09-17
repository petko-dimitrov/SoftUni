function clearView() {
    $('main > section').remove();
}

function showInfo(message) {
    let infoBox = $('#infoBox');
    infoBox.text(message);
    infoBox.show();
    setTimeout(function () {
        $('#infoBox').fadeOut()
    }, 3000)
}

function showError(errorMsg) {
    let errorBox = $('#errorBox');
    errorBox.text("Error: " + errorMsg);
    errorBox.show()
}

async function showHeader() {
    $('header').remove();
    let source = await $.get('./templates/menu.hbs');
    let template = Handlebars.compile(source);
    let context = {};
    if (sessionStorage.getItem('authToken') !== null) {
        context = {
            loggedIn: true
        }
    }
    let html = template(context);
    $('body').prepend(html);
    if (sessionStorage.getItem('authToken') !== null) {
        $('#loggedInUser').text(`Hello ${sessionStorage.getItem('username')}!`);
    }
    $("#linkHome").on('click', showHomeView);
    $("#linkLogin").on('click', showLoginRegisterView);
    $("#linkRegister").on('click', showLoginRegisterView);
    $("#linkListAds").on('click', listAds);
    $("#linkCreateAd").on('click', showCreateEditView);
    $("#linkLogout").on('click', logoutUser);
}

async function showHomeView() {
    clearView();
    let source = await $.get('./templates/home.hbs');
    let template = Handlebars.compile(source);
    $('main').append(template);
}

async function showLoginRegisterView() {
    clearView();
    let source = await $.get('./templates/loginRegister.hbs');
    let template = Handlebars.compile(source);
    let command = $(this).text();
    let context = {};
    if (command === 'Login') {
        context = {
            view: 'viewLogin',
            type: 'Login',
            id: 'formLogin',
            button: 'buttonLoginUser'
        };
    } else {
        context = {
            view: 'viewRegister',
            type: 'Register',
            id: 'formRegister',
            button: 'buttonRegisterUser'
        };
    }
    let html = template(context);
    $('main').append(html);
    $('form').trigger('reset');
    $("#buttonLoginUser").on('click', loginUser);
    $("#buttonRegisterUser").on('click', registerUser);
}


async function showCreateEditView() {
    clearView();
    let source = await $.get('./templates/createEdit.hbs');
    let template = Handlebars.compile(source);
    let command = $(this).text();
    let context = {};
    if (command === 'Create Advertisement') {
        context = {
            view: 'viewCreateAd',
            title: 'Create new Advertisement',
            id: 'formCreateAd',
            button: 'buttonCreateAd',
            btnValue: 'Create'
        };
    } else {
        context = {
            view: 'viewEditAd',
            title: 'Edit existing advertisement',
            id: 'formEditAd',
            button: 'buttonEditAd',
            btnValue: 'Edit'
        };
    }
    let html = template(context);
    $('main').append(html);
    $('form').trigger('reset');
    $("#buttonCreateAd").on('click', createAd);
    $("#buttonEditAd").on('click', editAd);
}

async function displayAds(res) {
    clearView();
    let partialSource = await $.get('./templates/advert.hbs');
    Handlebars.registerPartial('ad', partialSource);
    let source = await $.get('./templates/adsTable.hbs');
    let template = Handlebars.compile(source);
    let context = {adverts: res};
    let html = template(context);
    $('main').append(html);
    $('.readMore').on('click', function () {
        let ad = res[$(this).parent().attr('data-id')];
        displayReadMore(ad);
    });

    for (let i = 0; i < res.length; i++) {
        if (res[i]._acl.creator === sessionStorage.getItem('userId')) {
            let editBtn = $('<a href="#">[Edit]</a>').on('click', function () {
                let ad = res[$(this).parent().attr('data-id')];
                loadAdForEdit(ad);
            });
            let deleteBtn = $('<a href="#">[Delete]</a>').on('click', function () {
                let ad = res[$(this).parent().attr('data-id')];
                deleteAd(ad);
            });
            $(`.actionsTd[data-id="${i}"]`).append(editBtn)
                .append(deleteBtn);
        }
    }
}

async function displayReadMore(ad) {
    clearView();
    let source = await $.get('./templates/readMore.hbs');
    let template = Handlebars.compile(source);
    let context = {
        title: ad.title,
        image: ad.image,
        description: ad.description,
        price: ad.price,
        publisher: ad.publisher,
        date: ad.date
    };
    let html = template(context);
    $('main').append(html);
    $('.back').on('click', listAds)
}

