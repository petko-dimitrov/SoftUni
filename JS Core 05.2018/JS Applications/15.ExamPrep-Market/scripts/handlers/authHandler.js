handlers.getWelcomePage = function (ctx) {
    ctx.isAuth = auth.isAuth();

    ctx.loadPartials({
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs'
    }).then(function () {
        this.partial('./templates/home.hbs');
    })
};

handlers.getRegisterPage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs',
        registerForm: './templates/forms/registerForm.hbs'
    }).then(function () {
        this.partial('./templates/home/register.hbs');
    })
};

handlers.getLoginPage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs',
        loginForm: './templates/forms/loginForm.hbs'
    }).then(function () {
        this.partial('./templates/home/login.hbs');
    })
};

handlers.registerUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.password;
    const name = ctx.params.name;

    auth.register(username, password, name)
        .then((userData) => {
            auth.saveSession(userData);
            notify.showInfo('User registration successful.');
            ctx.redirect('#/userHome');
        })
        .catch(notify.handleError)
};

handlers.loginUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.password;

    auth.login(username, password)
        .then((userData) => {
            auth.saveSession(userData);
            notify.showInfo('Login successful.');
            ctx.redirect('#/userHome');
        })
        .catch(notify.handleError);
};
handlers.logout = function (ctx) {
    auth.logout()
        .then(() => {
            sessionStorage.clear();
            notify.showInfo('Logout successful.');
            ctx.redirect('#/home');
        })
};