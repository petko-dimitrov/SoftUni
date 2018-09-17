function fillForm(name, email, phone, arr) {
    for (let i = 0; i < arr.length; i++) {
        arr[i] = arr[i].replace(/<![a-zA-Z]+!>/g, name);
        arr[i] = arr[i].replace(/<@[a-zA-Z]+@>/g, email);
        arr[i] = arr[i].replace(/<\+[a-zA-Z]+\+>/g, phone);
    }

    console.log(arr.join('\n'));
}

fillForm('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']);
