handlers.getUserHome = function (ctx) {
    ctx.username = sessionStorage.getItem('username');
    ctx.isAuth = auth.isAuth();

    ctx.loadPartials({
        header: './templates/common/header.hbs',
        footer: './templates/common/footer.hbs'
    }).then(function () {
        this.partial('./templates/home/userHome.hbs')
    })
};

handlers.getShop = function (ctx) {
    ctx.username = sessionStorage.getItem('username');
    ctx.isAuth = auth.isAuth();

    market.getAllProducts().then(function (products) {
        products.forEach(p => p.price = p.price.toFixed(2));
        ctx.products = products;

        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            product: './templates/market/product.hbs'
        }).then(function () {
            this.partial('./templates/market/shop.hbs')
        })
    }).catch(notify.handleError);
};

handlers.getCart = function (ctx) {
    ctx.username = sessionStorage.getItem('username');
    ctx.isAuth = auth.isAuth();
    let userId = sessionStorage.getItem('userId');

    market.listUser(userId).then(function (res) {
        let products = [];
        for (const productId in res.cart) {
            let obj = {};
            obj.name = res.cart[productId].product.name;
            obj.description = res.cart[productId].product.description;
            obj.quantity = res.cart[productId].quantity;
            obj.totalPrice = (+obj.quantity * +res.cart[productId].product.price).toFixed(2);
            products.push(obj);
        }
        ctx.products = products;

        ctx.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            cartProduct: './templates/market/cartProduct.hbs'
        }).then(function () {
            this.partial('./templates/market/cart.hbs')
        })
     }).catch(notify.handleError)
};

handlers.purchase = function (ctx) {
    let name = ctx.params.product;
    let userId = sessionStorage.getItem('userId');

    Promise.all([market.getAllProducts(), market.listUser(userId)])
        .then(function ([products, userData]) {
            products = products.filter(p => p.name === name);
            let product = products[0];

            if (!userData.hasOwnProperty('cart')) {
                userData.cart = {};
                userData.cart[product._id] = {};
                userData.cart[product._id].quantity = 1;
                userData.cart[product._id].product = {
                    name: product.name,
                    description: product.description,
                    price: product.price
                };
            } else if (!userData.cart.hasOwnProperty(product._id)) {
                userData.cart[product._id] = {};
                userData.cart[product._id].quantity = 1;
                userData.cart[product._id].product = {
                    name: product.name,
                    description: product.description,
                    price: product.price
                };
            } else {
                userData.cart[product._id].quantity = +userData.cart[product._id].quantity + 1;
            }

            let data = userData.cart;
            
            market.updateUser(userId, data).then(function () {
                notify.showInfo('Product purchased.');
                ctx.redirect('#/cart');
            }).catch(notify.handleError);
    })
};

handlers.discard = function (ctx) {
    let name = ctx.params.product;
    let userId = sessionStorage.getItem('userId');

    Promise.all([market.getAllProducts(), market.listUser(userId)])
        .then(function ([products, userData]) {
            products = products.filter(p => p.name === name);
            let id = products[0]._id;
            delete userData.cart[id];
            let data = userData.cart;

            market.updateUser(userId, data).then(function () {
                notify.showInfo('Product discarded.');
                ctx.redirect('#/cart');
            }).catch(notify.handleError);
        })
};
