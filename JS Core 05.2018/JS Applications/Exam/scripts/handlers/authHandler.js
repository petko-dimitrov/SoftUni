handlers.getWelcomePage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs'
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
    const password = ctx.params.password;
    const passwordCheck = ctx.params.repeatPass;
    const userRegex = /^[A-Za-z]+$/;
    const passRegex = /^[A-Za-z0-9]+$/;

    if(username.length < 3){
        notify.showError('Username must be at least 3 symbols long!');
    } else if (!userRegex.test(username)) {
        notify.showError('Username should contain only english alphabet letters!')
    } else if (password.length < 6) {
        notify.showError('Password must be at least 6 symbols long!');
    } else if (!passRegex.test(password)) {
        notify.showError('Password should contain only english alphabet letters and digits!');
    } else if (password !== passwordCheck) {
        notify.showError('Both passwords must match!');
    } else {
        auth.register(username, password)
            .then((userData) => {
                auth.saveSession(userData);
                notify.showInfo('User registration successful.');
                ctx.redirect('#/listAll');
            })
            .catch(notify.handleError)
    }
};
handlers.loginUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.password;
    const userRegex = /^[A-Za-z]+$/;
    const passRegex = /^[A-Za-z0-9]+$/;

    if(username.length < 3){
        notify.showError('Username must be at least 3 symbols long!');
    } else if (!userRegex.test(username)) {
        notify.showError('Username should contain only english alphabet letters!')
    } else if (password.length < 6) {
        notify.showError('Password must be at least 6 symbols long!');
    } else if (!passRegex.test(password)) {
        notify.showError('Password should contain only english alphabet letters and digits!');
    } else {
        auth.login(username, password)
            .then((userData) => {
                auth.saveSession(userData);
                notify.showInfo('Login successful.');
                ctx.redirect('#/listAll');
            })
            .catch(notify.handleError);
    }
};
handlers.logout = function (ctx) {
    auth.logout()
        .then(() => {
            sessionStorage.clear();
            notify.showInfo('Logout successful.');
            ctx.redirect('#/login');
        })
};