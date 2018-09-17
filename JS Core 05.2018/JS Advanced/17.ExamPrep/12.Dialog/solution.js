class Dialog {
    constructor(message, callback) {
        this.message = message;
        this.callback = callback;
        this.labels = [];
        this.names = [];
        this.types = [];
    }

    addInput(label, name, type) {
        this.labels.push(label);
        this.names.push(name);
        this.types.push(type);
    }

    render() {
        let that = this;
        let div = $('<div class="overlay">');
        let dialogDiv = $('<div class="dialog">');
        dialogDiv
            .append(`<p>${this.message}</p>`);

        if(this.labels.length > 0) {
            for (let i = 0; i < this.labels.length; i++) {
                dialogDiv
                    .append(`<label>${this.labels[i]}</label>`)
                    .append(`<input name="${this.names[i]}" type="${this.types[i]}">`);
            }
        }

        let okBtn = $('<button>OK</button>').on('click', function () {
            let obj = {};

            if (that.labels.length > 0) {
                for (let i = 0; i < that.labels.length; i++) {
                    let input = $(`input[name="${that.names[i]}"]`);
                    if (input.val() !== '') {
                        obj[that.names[i]] = input.val();
                    }
                }
            }

            that.callback(obj);
            div.remove();
        });

        let cancelBtn = $('<button>Cancel</button>').on('click', function () {
            div.remove();
        });

        dialogDiv
            .append(okBtn)
            .append(cancelBtn);
        div.append(dialogDiv);

        $('body').append(div);
    }
}