function validate() {
    let userRegex = /^[a-zA-Z0-9]{3,20}$/;
    let passRegex = /^[\w]{5,15}$/;
    let mailRegex = /^.+@.*\.+.*$/;
    let submit = $("#submit");
    let username = $("#username");
    let password = $("#password");
    let passwordConfirm = $("#confirm-password");
    let email = $("#email");
    let checkbox = $("#company");
    let companyNumber = $("#companyNumber");

    checkbox.on('change', function () {
        if (checkbox.prop('checked')) {
            $("#companyInfo").css('display', 'block');
        } else {
            $("#companyInfo").css('display', 'none');
        }
    });

    submit.on('click', function (ev) {
        ev.preventDefault();
        let userValid = true;
        let passValid = true;
        let confirmPassValid = true;
        let mailValid = true;
        let companyValid = true;

        if (!userRegex.test(username.val())) {
            paintRed(username);
            userValid = false;
        } else {
            unpaint(username);
            userValid = true;
        }

        if (!mailRegex.test(email.val())) {
            paintRed(email);
            mailValid = false;
        } else {
            unpaint(email);
            mailValid = true;
        }

        if (password.val() !== passwordConfirm.val() || !passRegex.test(password.val())) {
            paintRed(passwordConfirm);
            paintRed(password);
            passValid = false;
            confirmPassValid = false;
        } else {
            unpaint(passwordConfirm);
            unpaint(password);
            passValid = true;
            confirmPassValid = true;
        }

        if (checkbox.prop('checked')) {
            if (companyNumber.val() < 1000 || companyNumber.val() > 9999) {
                paintRed(companyNumber);
                companyValid = false;
            } else {
                unpaint(companyNumber);
                companyValid = true;
            }
        }

        if (userValid && passValid && confirmPassValid && mailValid && companyValid) {
            $("#valid").css('display', 'block');
        } else {
            $("#valid").css('display', 'none');
        }
    });

    function paintRed(selector) {
        $(selector).css("border-color", "red");
    }

    function unpaint(selector) {
        $(selector).css("border-color", "");
    }
}
