class Contact {
    constructor(firstName, lastName, phone, email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
        this.email = email;
        this.online = false;
        this.contactBox = this.setHtml();
    }

    setHtml() {
        let that = this;
        let contactBox = $('<article>');

        let infoDiv = $('<div class="info">');
        infoDiv.css('display', 'none');
        infoDiv.append(`<span>&phone; ${that.phone}</span>`)
            .append(`<span>&#9993; ${that.email}</span>`);

        let infoBtn = $('<button>&#8505;</button>').on('click', function () {
            if(infoDiv.css('display') === 'none') {
                infoDiv.css('display', '');
            } else {
                infoDiv.css('display', 'none');
            }
        });

        let titleDiv = $(`<div class="title">${that.firstName} ${that.lastName}</div>`);
        titleDiv.append(infoBtn);

        contactBox.append(titleDiv)
            .append(infoDiv);

        return contactBox;
    }

    get online() {
        return this._online;
    }

    set online(value) {
        if (value === true) {
            $(this.contactBox).find('div').eq(0).addClass('online');
        } else {
            $(this.contactBox).find('div').eq(0).removeClass('online');
        }

        return this._online = value;
    }

    render(id) {
        $(`#${id}`).append(this.contactBox);
    }
}