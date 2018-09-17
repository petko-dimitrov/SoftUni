function attachEvents() {
    const BASE_URL = 'https://messenger-3c5a1.firebaseio.com/messenger';
    const TEXTAREA = $('#messages');
    const NAME_INPUT = $('#author');
    const MSG_INPUT = $('#content');

    $('#submit').on('click', function () {
        if (NAME_INPUT.val() !== '' && MSG_INPUT.val() !== '') {
            let name = NAME_INPUT.val();
            let message = MSG_INPUT.val();
            let data = JSON.stringify({
                author: name,
                content: message,
                timestamp: Date.now()
            });

            $.ajax({
                method: 'POST',
                url: BASE_URL + '.json',
                data: data
            }).catch(handleError);

            NAME_INPUT.val('');
            MSG_INPUT.val('');
        }
    });

    $('#refresh').on('click', function () {
        $.ajax({
            method: 'GET',
            url: BASE_URL + '.json'
        }).then(displayMessages)
            .catch(handleError)
    });

    function displayMessages(messages) {
        let result = '';
        let sortedMessages = Object.keys(messages).sort((a, b) => a.timestamp - b.timestamp);
        for (const message of sortedMessages) {
            let author = messages[message].author;
            let msg = messages[message].content;
            result += `${author}: ${msg}\n`;
        }
        TEXTAREA.text(result);
    }

    function handleError(err) {
        console.log(err);
    }
}