class Textbox {
    constructor(selector, regex) {
        this._elements = $(selector);
        this._invalidSymbols = regex;
        this._value = $(this._elements[0]).val();
        this.onInput();
    }

    get value() {
        return this._value;
    }

    set value(v) {
        this._value = v;
        for (const element of this.elements) {
            $(element).val(v);
        }
    }

    get elements() {
        return this._elements;
    }

    isValid() {
        return !this._invalidSymbols.test(this.value);
    }

    onInput () {
        this.elements.on('input', (ev) => {
            this.value = $(ev.target).val();
        });
    }
}

let textbox = new Textbox(".textbox",/[^a-zA-Z0-9]/);
let inputs = $('.textbox');

inputs.on('input',function(){console.log(textbox.value);});