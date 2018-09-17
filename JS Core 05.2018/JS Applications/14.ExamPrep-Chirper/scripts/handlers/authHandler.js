handlers.getWelcomePage = function (ctx) {
    ctx.loadPartials({
        loginForm: './templates/forms/loginForm.hbs',
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs'
    }).then(function () {
        this.partial('./templates/home.hbs');
    })
};

handlers.getRegisterPage = function (ctx) {
    ctx.loadPartials({
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs',
        registerForm: './templates/forms/registerForm.hbs'
    }).then(function () {
        this.partial('./templates/registerPage.hbs');
    })
};

handlers.registerUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.password;
    const passwordCheck = ctx.params.repeatPass;

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
                ctx.redirect('#/allChirps');
            })
            .catch(notify.handleError)
    }
};
handlers.loginUser = function (ctx) {
    const username = ctx.params.username;
    const password = ctx.params.password;

    if (username.length < 5) {
        notify.showError('Username must be at least 5 symbols long!');
    } else if (password.length === 0) {
        notify.showError('Password is requried!');
    } else {
        auth.login(username, password)
            .then((userData) => {
                auth.saveSession(userData);
                notify.showInfo('Login successful.');
                ctx.redirect('#/allChirps');
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