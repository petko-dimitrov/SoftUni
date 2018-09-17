const handlers = {};

$(() => {
    const app = Sammy('#app', function () {
        this.use('Handlebars', 'hbs');

        this.get('market.html', handlers.getWelcomePage);
        this.get('#/home', handlers.getWelcomePage);

        this.get('#/register', handlers.getRegisterPage);
        this.post('#/register', handlers.registerUser);

        this.get('#/login', handlers.getLoginPage);
        this.post('#/login', handlers.loginUser);
        this.get('#/logout', handlers.logout);

        this.get('#/userHome', handlers.getUserHome);
        this.get('#/shop', handlers.getShop);
        this.get('#/cart', handlers.getCart);

        this.get('/purchase/:product', handlers.purchase);
        this.get('/discard/:product', handlers.discard);
    });

    app.run();
});