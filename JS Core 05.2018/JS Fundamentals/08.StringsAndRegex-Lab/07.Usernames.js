function composeUsernames(arr) {
    let usernames = [];

    for (let i = 0; i < arr.length; i++) {
        let username = arr[i].split('@').shift() + '.';
        let address = arr[i].split('@').pop();
        let adressInfo = address.split('.').forEach(x => username += x[0]);

        // for (let info of adressInfo) {
        //     username += info[0];
        // }

        usernames.push(username);
    }

    console.log(usernames.join(', '));
}

composeUsernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);