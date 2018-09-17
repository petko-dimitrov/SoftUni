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

        this.get('#/addFlight', handlers.getCreatePage);
        this.post('#/addFlight', handlers.createFlight);

        this.get('#/details/:id', handlers.getFlightDetails);

        this.get('#/editFlight/:id', handlers.getEditFlight);
        this.post('#/editFlight/:id', handlers.postEditFlight);

        this.get('#/myFlights', handlers.getMyFlight);
        this.get('#/delete/:id', handlers.removeFlight)
    });

    app.run();
});
