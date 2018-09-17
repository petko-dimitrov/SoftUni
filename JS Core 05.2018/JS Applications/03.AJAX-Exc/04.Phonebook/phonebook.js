function attachEvents() {
    const BASE_URL = 'https://phonebook-nakov.firebaseio.com/phonebook';

    $('#btnLoad').on('click', loadContacts);
    $('#btnCreate').on('click', addContact);

    function loadContacts() {
        $('#phonebook').empty();
        $.ajax({
            method: 'GET',
            url: BASE_URL + '.json'
        }).then(displayContacts)
            .catch(handleError);
    }

    function addContact() {
        let personInput = $('#person');
        let phoneInput = $('#phone');
        let data = JSON.stringify({
            person: personInput.val(),
            phone: phoneInput.val()
        });

        if (personInput.val() !== '' && phoneInput.val() !== '') {
            $.ajax({
                method: 'POST',
                url: BASE_URL + '.json',
                data: data
            }).catch(handleError);
        }

        personInput.val('');
        phoneInput.val('');
    }

    function handleError(err) {
        console.log(err);
    }

    function displayContacts(contacts) {
        for (const key in contacts) {
            let name = contacts[key]['person'];
            let phone = contacts[key]['phone'];
            let li = $(`<li>`).text(`${name} : ${phone}`);
            li.append('<button>Delete</button>').on('click', function () {
                //li.remove();
                $.ajax({
                    method: 'DELETE',
                    url: BASE_URL + '/' + key + '.json'
                }).then(function () {
                    li.remove();
                }).catch(handleError)
            });
            $('#phonebook').append(li);
        }
    }
}
