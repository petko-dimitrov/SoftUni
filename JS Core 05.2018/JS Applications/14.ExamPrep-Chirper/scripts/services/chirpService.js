let chirp = (() => {
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

    function getAllSubs(subscriptions) {
        let endpoint = `chirps?query={"author":{"$in": [${subscriptions}]}}&sort={"_kmd.ect": 1}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function createChirp(text, author) {
        let data = {text, author};
        return requester.post('appdata', 'chirps', 'kinvey', data)
    }

    function deleteChirp(id) {
        let endpoint = `chirps/${id}`;
        return requester.remove('appdata', endpoint, 'kinvey');
    }

    function getChirpsByUser(username) {
        let endpoint = `chirps?query={"author":"${username}"}&sort={"_kmd.ect": 1}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }
    
    function countChirps(username) {
        let endpoint = `chirps?query={"author":"${username}"}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }
    
    function countFollowing(username) {
        let endpoint = `?query={"username":"${username}"}`;
        return requester.get('user', endpoint, 'kinvey');
    }

    function countFollowers(username) {
        let endpoint = `?query={"subscriptions":"${username}"}`;
        return requester.get('user', endpoint, 'kinvey');
    }

    function discoverPage() {
        return requester.get('user', '', 'kinvey');
    }

    function updateSubs(subscriptions) {
        let endpoint = sessionStorage.getItem('userId');
        let data = {
            subscriptions: subscriptions
        };
        return requester.update('user', endpoint, 'kinvey', data);
    }

    return {
        calcTime,
        getAllSubs,
        createChirp,
        deleteChirp,
        getChirpsByUser,
        countChirps,
        countFollowing,
        countFollowers,
        discoverPage,
        updateSubs
    }
})();