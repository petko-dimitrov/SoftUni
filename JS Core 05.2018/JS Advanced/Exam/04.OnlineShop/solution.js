function onlineShop(selector) {
    let form = `<div id="header">Online Shop Inventory</div>
    <div class="block">
        <label class="field">Product details:</label>
        <br>
        <input placeholder="Enter product" class="custom-select">
        <input class="input1" id="price" type="number" min="1" max="999999" value="1"><label class="text">BGN</label>
        <input class="input1" id="quantity" type="number" min="1" value="1"><label class="text">Qty.</label>
        <button id="submit" class="button" disabled>Submit</button>
        <br><br>
        <label class="field">Inventory:</label>
        <br>
        <ul class="display">
        </ul>
        <br>
        <label class="field">Capacity:</label><input id="capacity" readonly>
        <label class="field">(maximum capacity is 150 items.)</label>
        <br>
        <label class="field">Price:</label><input id="sum" readonly>
        <label class="field">BGN</label>
    </div>`;
    $(selector).html(form);

    let inventory = [];
    let product = $('.custom-select')
    let price = $('#price');
    let quantity = $('#quantity');
    let sum = $('#sum');
    let capacity = $('#capacity');
    let totalSum = 0;
    let totalQuantity = 0;

    let submit = $('#submit').on('click', function () {
        inventory.push({'product': product.val(),
            'price': price.val(),
        'quantity': quantity.val()});
        totalSum += Number(price.val());
        totalQuantity += Number(quantity.val());

        $('.display')
            .append(`<li>Product: ${product.val()} Price: ${price.val()} Quantity: ${quantity.val()}</li>`);
        sum.val(`${totalSum}`);

        if (totalQuantity >= 150) {
            capacity.addClass('fullCapacity');
            capacity.val(`full`);
            submit.attr('disabled','disabled');
            product.attr('disabled','disabled');
            price.attr('disabled','disabled');
            quantity.attr('disabled','disabled');
        } else {
            capacity.val(`${totalQuantity}`);
        }

        product.val('');
        price.val(1);
        quantity.val(1);
        submit.attr('disabled','disabled');
    });

    product.on('input', function () {
        if (product.val()) {
            submit.removeAttr('disabled')
        } else {
            submit.attr('disabled','disabled');
        }
    });
}