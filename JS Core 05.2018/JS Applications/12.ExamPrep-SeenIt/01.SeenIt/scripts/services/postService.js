let poster = (() => {
    function getAllPosts(author) {
        let endpoint = '';

        if (author) {
            endpoint = `posts?query={"author":"${author}"}&sort={"_kmd.ect": -1}`;
        } else {
            endpoint = 'posts?query={}&sort={"_kmd.ect": -1}'
        }
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function createPost(author, title, description, url, imageUrl) {
        let endpoint = 'posts';
        let data = {author, title, description, url, imageUrl};
        return requester.post('appdata', endpoint, 'kinvey', data);
    }

    function getPostById(id) {
        let endpoint = `posts/${id}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function editPost(id, author, title, description, url, imageUrl) {
        let endpoint = `posts/${id}`;
        let data = {author, title, description, url, imageUrl};
        return requester.update('appdata', endpoint, 'kinvey', data)
    }

    function deletePost(id) {
        let endpoint = `posts/${id}`;
        return requester.remove('appdata', endpoint, 'kinvey');
    }
    return {
        getAllPosts,
        createPost,
        getPostById,
        editPost,
        deletePost
    }
})();