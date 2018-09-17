$(() => {
    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        this.get('home', router.getHome);
        this.get('index.html', router.getHome);

        this.post('#/register', router.postRegister);
        this.post('#/login', router.loginUser);
        this.get('#/logout', router.logoutUser);

        this.get('#/catalog', router.getCatalog);

        this.get('#/postLink', router.getCreatePost);
        this.post('#/postLink', router.postCreatePost);

        this.get('#/edit/:id', router.getEditPost);
        this.post('#/edit/:id', router.postEditPost);

        this.get('#/delete/:id', router.deletePost);

        this.get('#/myPosts', router.getMyPosts);

        this.get('#/details/:postId', router.getDetails);
        this.post('#/createComment', router.postComment);
        this.get('#/deleteComment/:id/post/:postId', router.deleteComment);
    });

    app.run();
});
