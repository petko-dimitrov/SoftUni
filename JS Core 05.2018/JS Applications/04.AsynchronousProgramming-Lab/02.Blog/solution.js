function attachEvents() {
    let url = 'https://baas.kinvey.com/appdata/kid_BJsmrmQNQ/';
    let user = 'peter';
    let password = 'p';
    let base64auth = btoa(user + ':' + password);
    let authHeader = {"Authorization": "Basic " + base64auth};

    $('#btnLoadPosts').on('click', loadPosts);
    $('#btnViewPost').on('click', viewPost);

    function loadPosts() {
        $('#posts').empty();

        $.ajax({
            method: 'GET',
            url: url + 'posts',
            headers: authHeader
        }).then(function (result) {
            for (const post of result) {
                $('#posts').append(`<option value="${post._id}">${post.title}</option>`);
            }
        }).catch(function (err) {
            console.log(err);
        })
    }

    function viewPost() {
        let id = $('#posts').val();

        let reqPost = $.ajax({
            method: 'GET',
            url: url + `posts/${id}`,
            headers: authHeader
        });
        let reqComments = $.ajax({
            method: 'GET',
            url: url + `comments/?query={"post_id":"${id}"}`,
            headers: authHeader
        });

        Promise.all([reqPost, reqComments]).then(function ([post, comments]) {
            $('#post-title').text(`${post.title}`);
            $('#post-body').text(`${post.body}`);
            $('#post-comments').empty();
            for (const comm of comments) {
                $('#post-comments').append(`<li>${comm.text}</li>`);
            }
        }).catch(function (err) {
            console.log(err);
        })
    }
}