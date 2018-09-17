let homeService = (() => {
    function loadHome(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        ctx.hasTeam = sessionStorage.getItem('teamId') !== "undefined"
            || sessionStorage.getItem('teamId') !== null;
        ctx.teamId = sessionStorage.getItem('teamId');
        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs'
        }).then(function () {
                this.partial('./templates/home/home.hbs')
            }
        )
    }

    function loadAbout(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs'
        }).then(function (ctx) {
                this.partial('./templates/about/about.hbs')
            }
        )
    }

    function loadLogin(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            loginForm: './templates/login/loginForm.hbs'
        }).then(function (ctx) {
                this.partial('./templates/login/loginPage.hbs')
            }
        )
    }

    function loginUser(ctx) {
        let username = ctx.params.username;
        let password = ctx.params.password;
        auth.login(username, password)
            .then(function (userData) {
                auth.saveSession(userData);
                auth.showInfo('Logged in successfully!');
                loadHome(ctx);
            }).catch(auth.handleError)
    }

    function loadRegister(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        this.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            registerForm: './templates/register/registerForm.hbs'
        }).then(function (ctx) {
                this.partial('./templates/register/registerPage.hbs')
            }
        )
    }

    function registerUser(ctx) {
        let username = ctx.params.username;
        let password = ctx.params.password;
        let repeatPassword = ctx.params.repeatPassword;

        if (password !== repeatPassword) {
            auth.showError('Passwords must match!')
        } else {
            auth.register(username, password, repeatPassword).then(function (userInfo) {
                auth.saveSession(userInfo);
                auth.showInfo('Successfully registered!');
                this.redirect('#/home');
            }).catch(auth.handleError);
        }
    }

    function logout(ctx) {
        auth.logout()
            .then(function () {
                sessionStorage.clear();
                auth.showInfo('Logged out!');
                loadHome(ctx);
            })
            .catch(auth.handleError);
    }

    function loadCatalog(ctx) {
        teamsService.loadTeams()
            .then(function (data) {
                ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
                ctx.username = sessionStorage.getItem('username');
                ctx.hasTeam = sessionStorage.getItem('teamId') !== null;
                ctx.hasNoTeam = sessionStorage.getItem('teamId') === null
                    || sessionStorage.getItem('teamId') === "undefined";
                ctx.teams = data;
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    team: './templates/catalog/team.hbs'
                }).then(function () {
                    this.partial('./templates/catalog/teamCatalog.hbs');
                });
            });
    }

    function loadCreateTeam(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            createForm: './templates/create/createForm.hbs'
        }).then(function () {
            this.partial('./templates/create/createPage.hbs')
        })
    }

    function createTeam(ctx) {
        let name = ctx.params.name;
        let comment = ctx.params.comment;
        teamsService.createTeam(name, comment)
            .then(function (data) {
                teamsService.joinTeam(data._id)
                    .then((newData) => {
                        auth.saveSession(newData);
                        auth.showInfo('New team created!');
                        loadCatalog(ctx);
                    });
            });
    }

    function loadDetails(ctx) {
        let teamId = ctx.params.id.substr(1);
        teamsService.loadTeamDetails(teamId)
            .then(function (data) {
                ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
                ctx.username = sessionStorage.getItem('username');
                ctx.name = data.name;
                ctx.comment = data.comment;
                ctx.members = data.members;
                ctx.teamId = data._id;
                ctx.isOnTeam = data._id === sessionStorage.getItem('teamId');
                ctx.isAuthor = data._acl.creator === sessionStorage.getItem('userId');
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    teamMember: './templates/catalog/teamMember.hbs',
                    teamControls: './templates/catalog/teamControls.hbs'
                }).then(function () {
                    this.partial('./templates/catalog/details.hbs')
                })
            })
    }

    function loadEdit(ctx) {
        ctx.loggedIn = sessionStorage.getItem('authtoken') !== null;
        ctx.username = sessionStorage.getItem('username');
        ctx.teamId = this.params.id.substr(1);
        teamsService.loadTeamDetails(ctx.teamId)
            .then(function (data) {
                ctx.name = data.name;
                ctx.comment = data.comment;
                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    editForm: './templates/edit/editForm.hbs'
                }).then(function () {
                    this.partial('./templates/edit/editPage.hbs')
                })
            })
    }

    function editTeam(ctx) {
        let teamId = ctx.params.id.substr(1);
        let name = ctx.params.name;
        let description = ctx.params.comment;
        teamsService.edit(teamId, name, description)
            .then(function () {
                auth.showInfo('Team edited!');
                loadCatalog(ctx);
            }).catch(auth.handleError)
    }

    function leaveTeam(ctx) {
        teamsService.leaveTeam()
            .then(function (data) {
                auth.saveSession(data);
                auth.showInfo('Team has been left!');
                loadCatalog(ctx);
            })
    }

    function joinTeam(ctx) {
        let teamId = ctx.params.id.substr(1);
        teamsService.joinTeam(teamId)
            .then(function (data) {
            auth.saveSession(data);
            auth.showInfo('Joined new team!');
            loadCatalog(ctx);
        })
    }
    return {
        loadHome,
        loadAbout,
        loadLogin,
        loginUser,
        loadRegister,
        registerUser,
        logout,
        loadCatalog,
        loadCreateTeam,
        createTeam,
        loadDetails,
        loadEdit,
        editTeam,
        leaveTeam,
        joinTeam
    }
})();