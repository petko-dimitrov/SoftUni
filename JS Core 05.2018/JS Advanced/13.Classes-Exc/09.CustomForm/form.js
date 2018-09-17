let result = (function() {

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

    class Form {
        constructor() {
            this._element = $('<div>').addClass('form');
            this.textboxes = arguments;
        }

        get textboxes() {
            return this._textboxes;
        }

        set textboxes(value) {
            for (const argument of value) {
                if (!argument instanceof Textbox) {
                    throw new TypeError('Invalid input!')
                }
            }

            this._textboxes = value;

            for (const box of this._textboxes) {
                for (const element of box._elements) {
                    this._element.append($(element));
                }
            }
        }

        submit() {
            let allValid = true;

            for (const box of this._textboxes) {
                if (box.isValid()) {
                    for (const element of box._elements) {
                        $(element).css('border', '2px solid green');
                    }
                } else {
                    for (const element of box._elements) {
                        $(element).css('border', '2px solid red');
                    }
                    allValid = false;
                }
            }

            return allValid;
        }

        attach(selector) {
            $(selector).append(this._element);
        }
    }

    return {
        Textbox: Textbox,
        Form: Form
    }
}());

let Textbox = result.Textbox;
let Form = result.Form;
let username = new Textbox("#username",/[^a-zA-Z0-9]/);
let password = new Textbox("#password",/[^a-zA-Z]/);
username.value = "username";
password.value = "password2";
let form = new Form(username,password);
form.attach("#root");
form.submit();