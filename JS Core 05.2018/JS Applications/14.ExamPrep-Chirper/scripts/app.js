const handlers = {};

$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('skeleton.html', handlers.getWelcomePage);
        this.get('#/home', handlers.getWelcomePage);

        this.get('#/register', handlers.getRegisterPage);
        this.post('#/register', handlers.registerUser);

        this.post('#/login', handlers.loginUser);
        this.get('#/logout', handlers.logout);

        this.get('#/allChirps', handlers.getAll);
        this.get('#/getChirpsByUser/:username', handlers.getByUser);
        this.get('#/me', handlers.getMe);
        this.get('#/discover', handlers.discover);

        this.get('#/follow/:username', handlers.follow);
        this.get('#/unfollow/:username', handlers.unfollow);

        this.post('#/createChirp', handlers.create);
        this.get('#/delete/:id', handlers.removeChirp)
    });

    app.run();
});