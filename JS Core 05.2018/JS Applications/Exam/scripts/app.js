const handlers = {};

$(() => {
    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', handlers.getWelcomePage);
        this.get('#/home', handlers.getWelcomePage);

        this.get('#/register', handlers.getRegisterPage);
        this.post('#/register', handlers.registerUser);

        this.get('#/login', handlers.getLoginPage);
        this.post('#/login', handlers.loginUser);
        this.get('#/logout', handlers.logout);

        this.get('#/listAll', handlers.listAll);

        this.get('#/create', handlers.getCreateListing);
        this.post('#/create', handlers.createListing);

        this.get('#/edit/:id', handlers.getEditListing);
        this.post('#/edit/:id', handlers.editListing);

        this.get('#/delete/:id', handlers.deleteListing);

        this.get('#/listMine', handlers.listMine);
        this.get('#/details/:id', handlers.getDetails);
    });

    app.run();
});