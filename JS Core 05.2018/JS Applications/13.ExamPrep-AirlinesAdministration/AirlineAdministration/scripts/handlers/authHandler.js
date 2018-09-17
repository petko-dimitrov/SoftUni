handlers.getWelcomePage = async function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    let flights;
    if (auth.isAuth()) {
        flights = await flighServ.getAllFlights()
    }

    ctx.flights = flights;

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs',
        flight: './templates/flights/flight.hbs'
    }).then(function () {
        this.partial('./templates/welcome.hbs');
    })
};

handlers.getRegisterPage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs',
        registerForm: './templates/forms/registerForm.hbs'
    }).then(function () {
        this.partial('./templates/home/registerPage.hbs');
    })
};

handlers.getLoginPage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs',
        loginForm: './templates/forms/loginForm.hbs'
    }).then(function () {
        this.partial('./templates/home/loginPage.hbs');
    })
};

handlers.registerUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.pass;
    const passwordCheck = ctx.params.checkPass;

    if(username.length < 5){
        notify.showError('Username must be at least 5 symbols long!');
    } else if (password.length === 0) {
        notify.showError('Password must be non-empty!');
    } else if (password !== passwordCheck) {
        notify.showError('Both passwords must match!');
    } else {
        auth.register(username, password)
            .then((userData) => {
                auth.saveSession(userData);
                notify.showInfo('User registration successful.');
                ctx.redirect('#/home');
            })
            .catch(notify.handleError)
    }
};

handlers.loginUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.pass;

    if (username.length < 5) {
        notify.showError('Username must be at least 5 symbols long!');
    } else if (password.length === 0) {
        notify.showError('Password is requried!');
    } else {
        auth.login(username, password)
            .then((userData) => {
                auth.saveSession(userData);
                notify.showInfo('Login successful.');
                ctx.redirect('#/home');
            })
            .catch(notify.handleError);
    }
};
handlers.logout = function (ctx) {
    auth.logout()
        .then(() => {
            sessionStorage.clear();
            notify.showInfo('Logout successful.');
            ctx.redirect('#/home');
        })
};