class PaymentManager {
    constructor(title) {
        this.element = this.createElement(title);
    }

    createElement(title) {
        let table = $('<table>');
        let caption = $(`<caption>${title} Payment Manager</caption>`);
        let thead = $('<thead>\n' +
            '        <tr>\n' +
            '            <th class="name">Name</th>\n' +
            '            <th class="category">Category</th>\n' +
            '            <th class="price">Price</th>\n' +
            '            <th>Actions</th>\n' +
            '        </tr>\n' +
            '   </thead>');
        let tbody = $('<tbody class="payments">');
        let tfoot = $('<tfoot class="input-data">');
        let tfootRow = $('<tr>');
        let nameTd = $('<td><input name="name" type="text"></td>');
        let categoryTd = $('<td><input name="category" type="text"></td>');
        let priceTd = $('<td><input name="price" type="number"></td>');
        let addTd = $('<td>');
        let addBtn = $('<button>Add</button>').on('click', function () {
            let name = $(nameTd.children()[0]).val();
            let category = $(categoryTd.children()[0]).val();
            let price = $(priceTd.children()[0]).val();

            if (name && price && category) {
                let tr = $('<tr>');
                tr.append(`<td>${name}</td>`);
                tr.append(`<td>${category}</td>`);
                tr.append(`<td>${Math.round(Number(price) * 1000) / 1000}</td>`);
                let delTd = $('<td>');
                let delBtn = $('<button>Delete</button>').on('click', function () {
                    $(tr).remove();
                });
                delTd.append(delBtn);
                tr.append(delTd);
                tbody.append(tr);

                $(nameTd.children()[0]).val('');
                $(categoryTd.children()[0]).val('');
                $(priceTd.children()[0]).val('');
            }
        });
        tfootRow.append(nameTd);
        tfootRow.append(categoryTd);
        tfootRow.append(priceTd);
        addTd.append(addBtn);
        tfootRow.append(addTd);
        tfoot.append(tfootRow);
        table
            .append(caption)
            .append(thead)
            .append(tbody)
            .append(tfoot);
        return table;
    }

    render(selector) {
        let el = this.element;
        $(`#${selector}`).append(el);
    }
}