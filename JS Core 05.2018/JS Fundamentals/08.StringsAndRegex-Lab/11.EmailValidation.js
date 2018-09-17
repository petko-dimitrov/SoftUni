function validate(mail) {
    let regex = /^[a-zA-Z\d]+@[a-z]+\.[a-z]+$/g;

    if (regex.test(mail)){
        console.log("Valid");
    } else {
        console.log("Invalid");
    }
}

validate('invalid@emai1.bg');