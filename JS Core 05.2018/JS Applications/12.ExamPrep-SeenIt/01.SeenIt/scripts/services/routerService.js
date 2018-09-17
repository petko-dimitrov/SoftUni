let router = (() => {
    let usernameRegex = /^[A-Za-z]{3,}$/;
    let passRegex = /^[A-Za-z0-9]{6,}$/;
    let urlRegex = /^http.+$/;

    function getHome(ctx) {
        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            loginForm: './templates/forms/loginForm.hbs',
            registerForm: './templates/forms/registerForm.hbs'
        }).then(function () {
            this.partial('./templates/home.hbs');
        })
    }

    function postRegister(ctx) {
        let username = ctx.params.username;
        let password = ctx.params.password;
        let repeatPass = ctx.params.repeatPass;

        if (!usernameRegex.test(username)) {
            notify.showError('Username must consist of only latin letters and be at least 3 letter long!');
        } else if (!passRegex.test(password)) {
            notify.showError('Password must consist of only latin letters or digits and be at least 6 symbols long!');
        } else if (repeatPass !== password) {
            notify.showError('Passwords do not match!')
        } else {
            auth.register(username, password)
                .then((userData) => {
                    auth.saveSession(userData);
                    notify.showInfo('User registration successful!');
                    ctx.redirect('#/catalog');
                })
                .catch(notify.handleError);
        }
    }

    function loginUser(ctx) {
        let username = ctx.params.username;
        let password = ctx.params.password;
        if (!usernameRegex.test(username)) {
            notify.showError('Username must consist of only latin letters and be at least 3 letter long!');
        } else if (!passRegex.test(password)) {
            notify.showError('Password must consist of only latin letters or digits and be at least 6 symbols long!');
        } else {
            auth.login(username, password).then(function (userData) {
                notify.showInfo('Login successful.');
                auth.saveSession(userData);
                ctx.redirect('#/catalog')
            }).catch(notify.handleError)
        }
    }

    function logoutUser(ctx) {
        auth.logout().then(function () {
            sessionStorage.clear();
            ctx.redirect('#/home');
        }).catch(notify.handleError)
    }

    function getCatalog(ctx) {
        if (!auth.isAuth()) {
            ctx.redirect('#/home');
        }

        poster.getAllPosts('').then(function (posts) {
            posts.forEach((p, i) => {
                p.time = calcTime(p._kmd.ect);
                p.isAuthor = p._acl.creator === sessionStorage.getItem('userId');
                p.rank = i + 1;
            });

            ctx.isAuth = auth.isAuth();
            ctx.username = sessionStorage.getItem('username');
            ctx.posts = posts;

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                nav: './templates/common/nav.hbs',
                post: './templates/posts/post.hbs'
            }).then(function () {
                this.partial('./templates/posts/catalog.hbs')
            }).catch(notify.handleError)
        })
    }

    function getCreatePost(ctx) {
        if (!auth.isAuth()) {
            ctx.redirect('#/home');
        }

        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');

        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            nav: './templates/common/nav.hbs',
            createForm: './templates/forms/createForm.hbs'
        }).then(function () {
            this.partial('./templates/posts/createPost.hbs')
        })
    }

    function postCreatePost(ctx) {
        let url = ctx.params.url;
        let title = ctx.params.title;
        let imageUrl = ctx.params.image;
        let description = ctx.params.comment;
        let author = sessionStorage.getItem('username');

        if (url === '') {
            notify.showError('Please enter an url.')
        }
        else if (!urlRegex.test(url)) {
            notify.showError('Link url should always start with http!');
        } else if (title === '') {
            notify.showError('Please enter a title.')
        } else {
            poster.createPost(author, title, description, url, imageUrl).then(function () {
                notify.showInfo('Post created.');
                ctx.redirect('#/catalog');
            }).catch(notify.handleError)
        }
    }

    function getEditPost(ctx) {
        if (!auth.isAuth()) {
            ctx.redirect('#/home');
        }

        let id = ctx.params.id;
        poster.getPostById(id).then(function (postData) {
            ctx.isAuth = auth.isAuth();
            ctx.username = sessionStorage.getItem('username');
            ctx.id = id;
            ctx.url = postData.url;
            ctx.title = postData.title;
            ctx.imageUrl = postData.imageUrl;
            ctx.description = postData.description;

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                nav: './templates/common/nav.hbs',
                editForm: './templates/forms/editForm.hbs'
            }).then(function () {
                this.partial('./templates/posts/editPost.hbs');
            }).catch(notify.handleError)
        });
    }

    function postEditPost(ctx) {
        let id = ctx.params.postId;
        let url = ctx.params.url;
        let title = ctx.params.title;
        let imageUrl = ctx.params.image;
        let description = ctx.params.description;
        let author = sessionStorage.getItem('username');

        if (url === '') {
            notify.showError('Please enter an url.')
        }
        else if (!urlRegex.test(url)) {
            notify.showError('Link url should always start with http!');
        } else if (title === '') {
            notify.showError('Please enter a title.')
        } else {
            poster.editPost(id, author, title, description, url, imageUrl).then(function () {
                notify.showInfo(`Post ${title} updated.`);
                ctx.redirect('#/catalog');
            }).catch(notify.handleError)
        }
    }

    function deletePost(ctx) {
        let id = ctx.params.id;
        poster.deletePost(id).then(function () {
            notify.showInfo('Post deleted.');
            ctx.redirect('#/catalog');
        }).catch(notify.handleError)
    }

    function getMyPosts(ctx) {
        if (!auth.isAuth()) {
            ctx.redirect('#/home');
        }

        let author = sessionStorage.getItem('username');

        poster.getAllPosts(author).then(function (posts) {
            posts.forEach((p, i) => {
                p.time = calcTime(p._kmd.ect);
                p.isAuthor = p._acl.creator === sessionStorage.getItem('userId');
                p.rank = i + 1;
            });

            ctx.isAuth = auth.isAuth();
            ctx.username = sessionStorage.getItem('username');
            ctx.posts = posts;

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                nav: './templates/common/nav.hbs',
                post: './templates/posts/post.hbs'
            }).then(function () {
                this.partial('./templates/posts/catalog.hbs')
            }).catch(notify.handleError)
        })
    }

    function getDetails(ctx) {
        let id = ctx.params.postId;

        let postPromise = poster.getPostById(id);
        let commentsPromise = commenter.getComments(id);

        Promise.all([postPromise, commentsPromise])
            .then(([post, comments]) => {
                ctx.isAuth = auth.isAuth();
                ctx.username = sessionStorage.getItem('username');
                ctx.url = post.url;
                ctx.title = post.title;
                ctx.imageUrl = post.imageUrl;
                ctx.time = calcTime(post._kmd.ect);
                ctx.author = post.author;
                ctx.description = post.description;
                ctx.isAuthor = post._acl.creator === sessionStorage.getItem('userId');
                ctx._id = post._id;

                comments.forEach((c) => {
                    c.commentTime = calcTime(c._kmd.ect);
                    c.commentAuthor = c.author;
                    c.commentText = c.content;
                    c.isCommentAuthor = c._acl.creator === sessionStorage.getItem('userId');
                });

                ctx.comments = comments;

                ctx.loadPartials({
                    header: './templates/common/header.hbs',
                    footer: './templates/common/footer.hbs',
                    nav: './templates/common/nav.hbs',
                    commentForm: './templates/forms/commentForm.hbs',
                    comment: './templates/posts/comment.hbs'
                }).then(function () {
                    this.partial('./templates/posts/details.hbs')
                }).catch(notify.handleError)
            })
    }

    function postComment(ctx) {
        console.log(ctx);
        let postId = ctx.params.postId;
        let content = ctx.params.content;
        let author = sessionStorage.getItem('username');
        
        commenter.createComment(postId, content, author).then(function () {
            notify.showInfo('Comment created.');
            ctx.redirect(`#/details/${postId}`);
        }).catch(notify.handleError)
    }

    function deleteComment(ctx) {
        let id = ctx.params.id;
        let postId = ctx.params.postId;
        commenter.deleteComm(id).then(function () {
            notify.showInfo('Comment deleted.');
            ctx.redirect(`#/details/${postId}`);
        }).catch(notify.handleError);
    }

    function calcTime(dateIsoFormat) {
        let diff = new Date - (new Date(dateIsoFormat));
        diff = Math.floor(diff / 60000);
        if (diff < 1) return 'less than a minute';
        if (diff < 60) return diff + ' minute' + pluralize(diff);
        diff = Math.floor(diff / 60);
        if (diff < 24) return diff + ' hour' + pluralize(diff);
        diff = Math.floor(diff / 24);
        if (diff < 30) return diff + ' day' + pluralize(diff);
        diff = Math.floor(diff / 30);
        if (diff < 12) return diff + ' month' + pluralize(diff);
        diff = Math.floor(diff / 12);
        return diff + ' year' + pluralize(diff);

        function pluralize(value) {
            if (value !== 1) return 's';
            else return '';
        }
    }

    return {
        getHome,
        postRegister,
        getCatalog,
        loginUser,
        logoutUser,
        getCreatePost,
        getMyPosts,
        postCreatePost,
        getEditPost,
        postEditPost,
        deletePost,
        getDetails,
        postComment,
        deleteComment
    }
})();