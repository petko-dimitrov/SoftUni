let flighServ = (() => {
    function getAllFlights() {
        let endpoint = `flights?query={"isPublic":"true"}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }
    
    function addFlight(destination, origin, date, time, seats, cost, image, isPublic) {
        let endpoint = 'flights';
        let data = {destination, origin, date, time, seats, cost, image, isPublic};
        return requester.post('appdata', endpoint, 'kinvey', data);
    }

    function getFlightById(id) {
        let endpoint = `flights/${id}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }
    
    function editFlight(id, destination, origin, date, time, seats, cost, image, isPublic) {
        let endpoint = `flights/${id}`;
        let data = {destination, origin, date, time, seats, cost, image, isPublic};

        return requester.update('appdata', endpoint, 'kinvey', data);
    }

    function deleteFlight(id) {
        let endpoint = `flights/${id}`;
        return requester.remove('appdata', endpoint, 'kinvey');
    }

    function getMyFlights(userId) {
        let endpoint = `flights?query={"_acl.creator":"${userId}"}`;
        return requester.get('appdata', endpoint, 'kinvey');
    }


    return {
        getAllFlights,
        getFlightById,
        addFlight,
        editFlight,
        deleteFlight,
        getMyFlights
    }
})();