let commenter = (() => {
    function getComments(id) {
        let endpoint = `comments?query={"postId":"${id}"}&sort={"_kmd.ect": -1}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function createComment(postId, content, author) {
        let endpoint = 'comments';
        let data = {postId, content, author};
        return requester.post('appdata', endpoint, 'kinvey', data);
    }

    function deleteComm(id) {
        let endpoint = `comments/${id}`;
        return requester.remove('appdata', endpoint, 'kinvey');
    }

    return {
        getComments,
        createComment,
        deleteComm
    }
})();