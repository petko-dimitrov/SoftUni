let auth = (() => {
    function isAuth() {
        return sessionStorage.getItem('authtoken') !== null;
    }

    function saveSession(userData) {
        sessionStorage.setItem('authtoken', userData._kmd.authtoken);
        sessionStorage.setItem('userId', userData._id);
        sessionStorage.setItem('username', userData.username);
    }

    function register(username, password, name) {
        let obj = {username, password, name};
        return requester.post('user', '', 'basic', obj);
    }

    function login(username, password) {
        let obj = {username, password};
        return requester.post('user', 'login', 'basic', obj);
    }

    function logout() {
        return requester.post('user', '_logout', 'kinvey');
    }

    return {
        isAuth,
        saveSession,
        register,
        login,
        logout
    }
})();