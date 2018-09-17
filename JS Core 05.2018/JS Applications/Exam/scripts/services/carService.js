let carService = (() => {
    function getAllCars() {
        let endpoint = 'cars?query={}&sort={"_kmd.ect": -1}';
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function createCar(brand, description, fuel, imageUrl, model, price, seller, title, year) {
        let data = {brand, description, fuel, imageUrl, model, price, seller, title, year};
        return requester.post('appdata', 'cars', 'kinvey', data);
    }

    function getCarById(id) {
        let endpoint = `cars/${id}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }

    function editCar(id, brand, description, fuel, imageUrl, model, price, seller, title, year) {
        let endpoint = `cars/${id}`;
        let data = {brand, description, fuel, imageUrl, model, price, seller, title, year}
        return requester.update('appdata', endpoint, 'kinvey', data);
    }

    function deleteCar(id) {
        let endpoint = `cars/${id}`;
        return requester.remove('appdata', endpoint, 'kinvey');
    }

    function getMyCars(username) {
        let endpoint = `cars?query={"seller":"${username}"}&sort={"_kmd.ect": -1}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }


    return {
        getAllCars,
        createCar,
        getCarById,
        editCar,
        deleteCar,
        getMyCars
    }
})();