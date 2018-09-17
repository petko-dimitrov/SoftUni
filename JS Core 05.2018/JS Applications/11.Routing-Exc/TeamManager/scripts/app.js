$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', homeService.loadHome);
        this.get('#/home', homeService.loadHome);
        this.get('#/about', homeService.loadAbout);

        this.get('#/login', homeService.loadLogin);
        this.post('#/login', homeService.loginUser);


        this.get('#/register', homeService.loadRegister);
        this.post('#/register', homeService.registerUser);

        this.get('#/logout', homeService.logout);

        this.get('#/catalog', homeService.loadCatalog);
        this.get('#/create', homeService.loadCreateTeam);
        this.post('#/create', homeService.createTeam);
        this.get('#/catalog/:id', homeService.loadDetails);

        this.get('#/edit/:id', homeService.loadEdit);
        this.post('#/edit/:id', homeService.editTeam);
        this.get('#/leave', homeService.leaveTeam);
        this.get('#/join/:id', homeService.joinTeam);
    });

    app.run();
});