handlers.getAll = function (ctx) {
    let subscriptions;
    try {
        subscriptions = JSON.parse(sessionStorage.getItem('subscriptions')).map(e => `"${e}"`);
    } catch (e) {
        subscriptions = [];
    }

    ctx.username = sessionStorage.getItem('username');


    Promise.all([chirp.getAllSubs(subscriptions), chirp.countChirps(ctx.username)], chirp.countFollowers(ctx.username))
        .then(function ([chirps, myChirps, followers]) {
            chirps.forEach(c => c.time = chirp.calcTime(c._kmd.ect));
            ctx.chirps = chirps;
            ctx.count = myChirps.length;
            ctx.following = 0;
            if (subscriptions) {
                ctx.following = subscriptions.length;
            }
            ctx.followers = 0;
            if (followers) {
                ctx.followers = followers.length;
            }

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                menu: './templates/common/menu.hbs',
                stats: './templates/chirps/stats.hbs',
                createForm: './templates/forms/createForm.hbs',
                chirp: './templates/chirps/chirp.hbs'
            }).then(function () {
                this.partial('./templates/chirps/feed.hbs')
            })
        });
};

handlers.getByUser = function (ctx) {
    let username = ctx.params.username;
    let mySubscriptions = getMySubs();

    Promise.all([chirp.getChirpsByUser(username),chirp.countFollowing(username), chirp.countFollowers(username)])
        .then(function ([chirps, following, followers]) {
            ctx.username = username;
            chirps.forEach(c => c.time = chirp.calcTime(c._kmd.ect));
            ctx.chirps = chirps;
            ctx.count = 0;
            if (chirps) {
                ctx.count = chirps.length;
            }

            ctx.following = 0;
            if (following[0].subscriptions) {
                ctx.following = following[0].subscriptions.length;
            }

            ctx.followers = 0;
            if (followers) {
                ctx.followers = followers.length;
            }

            ctx.followed = mySubscriptions.includes(username);

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                menu: './templates/common/menu.hbs',
                stats: './templates/chirps/stats.hbs',
                chirp: './templates/chirps/chirp.hbs'
            }).then(function () {
                this.partial('./templates/chirps/userPage.hbs')
            })
        })
};

handlers.getMe = function (ctx) {
    let username = sessionStorage.getItem('username');
    ctx.username = username;

    Promise.all([chirp.getChirpsByUser(username),chirp.countFollowing(username), chirp.countFollowers(username)])
        .then(function ([chirps, following, followers]) {
            chirps.forEach(c => {
                c.time = chirp.calcTime(c._kmd.ect);
                c.isAuthor = true;
            });
            ctx.chirps = chirps;
            ctx.count = 0;
            if (chirps) {
                ctx.count = chirps.length;
            }

            ctx.following = 0;
            if (following[0].subscriptions)  {
                ctx.following = following[0].subscriptions.length;
            }

            ctx.followers = 0;
            if (followers) {
                ctx.followers = followers.length;
            }

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                menu: './templates/common/menu.hbs',
                createForm: './templates/forms/createForm.hbs',
                stats: './templates/chirps/stats.hbs',
                chirp: './templates/chirps/chirp.hbs'
            }).then(function () {
                this.partial('./templates/chirps/myPage.hbs')
            })
        })
};

handlers.create = function (ctx) {
      let text = ctx.params.text;
      let author = sessionStorage.getItem('username');
      
      if (text === '') {
          notify.showError('Chirp cannot be empty!');
      } else if (chirp.length > 150) {
          notify.showError('Chirp cannot be longer than 150 symbols!');
      } else {
          chirp.createChirp(text, author).then(function () {
                notify.showInfo('Chirp published.');
                ctx.redirect('#/me');
          }).catch(notify.handleError)
      }
};

handlers.removeChirp = function (ctx) {
    let id = ctx.params.id;
    chirp.deleteChirp(id).then(function () {
        notify.showInfo('Chirp deleted.');
        ctx.redirect('#/me');
    }).catch(notify.handleError);
};

handlers.discover = function (ctx) {
    chirp.discoverPage().then(function (users) {
        users.forEach(u => {
            chirp.countFollowers(u.username).then(function (followers) {
                    u.followers = followers.length;
            });
        });

        users = users.filter(u => u.username !== sessionStorage.getItem('username'));
        ctx.users = users.sort((a, b) => b.followers - a.followers);

        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            menu: './templates/common/menu.hbs',
            userBox: './templates/chirps/userBox.hbs'
        }).then(function () {
            this.partial('./templates/chirps/discover.hbs')
        })
    })
};

handlers.follow = function (ctx) {
    let mySubscriptions = getMySubs();
    let username = ctx.params.username;
    mySubscriptions.push(username);

    chirp.updateSubs(mySubscriptions).then(function () {
        notify.showInfo(`Subscribed to ${username}`);
        sessionStorage.setItem('subscriptions', JSON.stringify(mySubscriptions));
        ctx.redirect('#/allChirps');
    }).catch(notify.handleError)
};

handlers.unfollow = function (ctx) {
    let mySubscriptions = getMySubs();
    let username = ctx.params.username;
    mySubscriptions = mySubscriptions.filter(sub => sub !== username);

    chirp.updateSubs(mySubscriptions).then(function () {
        notify.showInfo(`Unsubscribed from ${username}`);
        sessionStorage.setItem('subscriptions', JSON.stringify(mySubscriptions));
        ctx.redirect('#/allChirps');
    }).catch(notify.handleError)
};

function getMySubs() {
    let mySubscriptions;
    try {
        return mySubscriptions = JSON.parse(sessionStorage.getItem('subscriptions')).map(e => `${e}`);
    } catch (e) {
        return mySubscriptions = [];
    }
}