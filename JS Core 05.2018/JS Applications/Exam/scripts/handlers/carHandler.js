handlers.listAll = function (ctx) {
    carService.getAllCars().then(function (cars) {
        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');
        cars.forEach(c => {
            c.isAuthor = c._acl.creator === sessionStorage.getItem('userId');
        });
        ctx.cars = cars;

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs',
            listing: './templates/cars/listing.hbs'
        }).then(function () {
            this.partial('./templates/cars/allCars.hbs')
        })
    }).catch(notify.handleError)
};

handlers.getCreateListing = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        menu: './templates/common/menu.hbs',
        footer: './templates/common/footer.hbs',
        createForm: './templates/forms/createForm.hbs'
    }).then(function () {
        this.partial('./templates/cars/createListing.hbs')
    })
};

handlers.createListing = function (ctx) {
    let brand = ctx.params.brand;
    let description = ctx.params.description;
    let fuel = ctx.params.fuelType;
    let imageUrl = ctx.params.imageUrl;
    let model = ctx.params.model;
    let price = ctx.params.price;
    let seller = sessionStorage.getItem('username');
    let title = ctx.params.title;
    let year = ctx.params.year;

    if (title.length > 33) {
        notify.showError('The title length must not exceed 33 characters!');
    } else if (description.length > 450) {
        notify.showError('The description length must not exceed 450 characters!');
    } else if (description.length < 30) {
        notify.showError('The description length should be at least 30 characters!');
    } else if (brand.length > 11) {
        notify.showError('The brand length must not exceed 11 characters!');
    } else if (fuel.length > 11) {
        notify.showError('The fuel type length must not exceed 11 characters!');
    } else if (model.length > 11) {
        notify.showError('The model length must not exceed 11 characters!');
    } else if (model.length < 4) {
        notify.showError('The model length should be at least 4 characters!');
    } else if (year < 1000 || year > 9999) {
        notify.showError('The year must be only 4 chars long!');
    } else if (price > 1000000) {
        notify.showError('The maximum price is 1000000$!');
    } else if (price <= 0) {
        notify.showError('The price must be positive!');
    } else if (!imageUrl.startsWith('http')) {
        notify.showError('Link url should always start with "http"!');
    } else if (brand === '' || description === '' || fuel === '' || imageUrl === '' || model === '' ||
    price === '' || seller === '' || title === '' || year === '') {
        notify.showError('Please fill all fields!')
    } else {
        carService.createCar(brand, description, fuel, imageUrl, model, price, seller, title, year).then(function () {
            notify.showInfo('listing created.');
            ctx.redirect('#/listAll');
        }).catch(notify.handleError);
    }
};

handlers.getEditListing = function (ctx) {
    let id = ctx.params.id;

    carService.getCarById(id).then(function (car) {
        ctx.isAuth = auth.isAuth();
        ctx.username = sessionStorage.getItem('username');
        ctx.car = car;

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs',
            editForm: './templates/forms/editForm.hbs'
        }).then(function () {
            this.partial('./templates/cars/editListing.hbs');
        })
    }).catch(notify.handleError);
};

handlers.editListing = function (ctx) {
    let id = ctx.params.carId;
    let brand = ctx.params.brand;
    let description = ctx.params.description;
    let fuel = ctx.params.fuelType;
    let imageUrl = ctx.params.imageUrl;
    let model = ctx.params.model;
    let price = ctx.params.price;
    let seller = sessionStorage.getItem('username');
    let title = ctx.params.title;
    let year = ctx.params.year;

    if (title.length > 33) {
        notify.showError('The title length must not exceed 33 characters!');
    } else if (description.length > 450) {
        notify.showError('The description length must not exceed 450 characters!');
    } else if (description.length < 30) {
        notify.showError('The description length should be at least 30 characters!');
    } else if (brand.length > 11) {
        notify.showError('The brand length must not exceed 11 characters!');
    } else if (fuel.length > 11) {
        notify.showError('The fuel type length must not exceed 11 characters!');
    } else if (model.length > 11) {
        notify.showError('The model length must not exceed 11 characters!');
    } else if (model.length < 4) {
        notify.showError('The model length should be at least 4 characters!');
    } else if (year < 1000 || year > 9999) {
        notify.showError('The year must be only 4 chars long!');
    } else if (price > 1000000) {
        notify.showError('The maximum price is 1000000$!');
    } else if (price <= 0) {
        notify.showError('The price must be positive!');
    } else if (!imageUrl.startsWith('http')) {
        notify.showError('Link url should always start with "http"!');
    } else if (brand === '' || description === '' || fuel === '' || imageUrl === '' || model === '' ||
        price === '' || seller === '' || title === '' || year === '') {
        notify.showError('Please fill all fields!')
    } else {
        carService.editCar(id, brand, description, fuel, imageUrl, model, price, seller, title, year).then(function () {
            notify.showInfo(`Listing ${title} updated.`);
            ctx.redirect('#/listAll');
        }).catch(notify.handleError);
    }
};

handlers.deleteListing = function (ctx) {
    let id = ctx.params.id;
    carService.deleteCar(id).then(function () {
        notify.showInfo('Listing deleted.');
        ctx.redirect('#/listAll');
    }).catch(notify.handleError);
};

handlers.listMine = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');

    carService.getMyCars(ctx.username).then(function (cars) {
        ctx.cars = cars;

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs',
            myListing: './templates/cars/myListing.hbs'
        }).then(function () {
            this.partial('./templates/cars/myCars.hbs')
        })
    }).catch(notify.handleError)
};

handlers.getDetails = function (ctx) {
    ctx.isAuth = auth.isAuth();
    ctx.username = sessionStorage.getItem('username');
    let id = ctx.params.id;

    carService.getCarById(id).then(function (car) {
        ctx.car = car;
        ctx.isAuthor = car._acl.creator === sessionStorage.getItem('userId');

        ctx.loadPartials({
            menu: './templates/common/menu.hbs',
            footer: './templates/common/footer.hbs'
        }).then(function () {
            this.partial('./templates/cars/details.hbs')
        })
    }).catch(notify.handleError);
};