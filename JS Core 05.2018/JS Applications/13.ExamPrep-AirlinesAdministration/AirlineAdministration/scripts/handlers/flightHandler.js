handlers.getCreatePage = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs',
        addForm: './templates/forms/addForm.hbs'
    }).then(function () {
        this.partial('./templates/flights/addFlight.hbs');
    })
};

handlers.createFlight = function (ctx) {
    let destination = ctx.params.destination;
    let origin = ctx.params.origin;
    let date = ctx.params.departureDate;
    let time = ctx.params.departureTime;
    let seats = +ctx.params.seats;
    let cost = +ctx.params.cost;
    let image = ctx.params.img;
    let isPublic = '';
    if (ctx.params.public === 'on') {
        isPublic = 'true';
    } else {
        isPublic = 'false';
    }

    if (isNaN(seats) || isNaN(cost)) {
        notify.showError('Seats and cost must be numbers!');
    } else if (destination === ''){
        notify.showError('Destination required!');
    } else if (origin === ''){
        notify.showError('Origin required!');
    } else if (seats < 1) {
        notify.showError('Seats must be positive!')
    } else if (cost <= 0) {
        notify.showError('Cost must be positive!')
    } else {
        flighServ.addFlight(destination, origin, date, time, seats, cost, image, isPublic).then(function () {
            notify.showInfo('Created flight.');
            ctx.redirect('#/home');
        }).catch(notify.handleError);
    }

};

handlers.getFlightDetails = function (ctx) {
    let id = ctx.params.id;
    
    flighServ.getFlightById(id).then(function (flight) {
        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');
        ctx.flight = flight;
        ctx.isAuthor = flight._acl.creator === sessionStorage.getItem('userId');

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs'
        }).then(function () {
            this.partial('./templates/flights/details.hbs');
        })
    }).catch(notify.handleError);
};

handlers.getEditFlight = function (ctx) {
    let id = ctx.params.id;
    flighServ.getFlightById(id).then(function (flight) {
        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');
        ctx.flight = flight;
        ctx.isPublic = flight.isPublic;

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs',
            editForm: './templates/forms/editForm.hbs'
        }).then(function () {
            this.partial('./templates/flights/editFlight.hbs');
        })
    }).catch(notify.handleError);
};

handlers.postEditFlight = function (ctx) {
    let id = ctx.params.flightId;
    let destination = ctx.params.destination;
    let origin = ctx.params.origin;
    let date = ctx.params.departureDate;
    let time = ctx.params.departureTime;
    let seats = +ctx.params.seats;
    let cost = +ctx.params.cost;
    let image = ctx.params.img;
    let isPublic = '';
    if (ctx.params.public === 'on') {
        isPublic = 'true';
    } else {
        isPublic = 'false';
    }

    if (isNaN(seats) || isNaN(cost)) {
        notify.showError('Seats and cost must be numbers!');
    } else if (destination === ''){
        notify.showError('Destination required!');
    } else if (origin === ''){
        notify.showError('Origin required!');
    } else if (seats < 1) {
        notify.showError('Seats must be positive!')
    } else if (cost <= 0) {
        notify.showError('Cost must be positive!')
    } else {
        flighServ.editFlight(id, destination, origin, date, time, seats, cost, image, isPublic).then(function () {
            notify.showInfo('Successfully edited flight.');
            ctx.redirect(`#/details/${id}`);
        }).catch(notify.handleError);
    }
};

handlers.getMyFlight = function (ctx) {
    let userId = sessionStorage.getItem('userId');
    flighServ.getMyFlights(userId).then(function (flights) {
        ctx.flights = flights;
        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs',
            myFlight: './templates/flights/myFlight.hbs'
        }).then(function () {
            this.partial('./templates/flights/myFlights.hbs')
        })
    });
};

handlers.removeFlight = function (ctx) {
    let id = ctx.params.id;
    flighServ.deleteFlight(id).then(function () {
        notify.showInfo('Flight deleted.');
        ctx.redirect('#/myFlights');
    }).catch(notify.handleError);
};