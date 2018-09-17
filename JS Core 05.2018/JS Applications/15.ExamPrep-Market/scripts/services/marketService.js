let market = (() => {
    function getAllProducts() {
        return requester.get('appdata', 'products', 'kinvey');
    }
    
    function listUser(userId) {
        return requester.get('user', userId, 'kinvey');
    }

    function updateUser(userId, data) {
        let obj = {
            cart: data
        };
        return requester.update('user', userId, 'kinvey', obj);
    }

    return {
        getAllProducts,
        listUser,
        updateUser
    }
})();