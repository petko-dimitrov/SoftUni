function attachEvents() {
    let url = 'https://baas.kinvey.com/appdata/kid_SyOjKqENX/';
    let user = 'Pesho';
    let password = '123';
    let base64auth = btoa(user + ':' + password);
    let authHeader = {"Authorization": "Basic " + base64auth};
    let displayDiv = $('#display');

    $(document).on({
        ajaxStart: function() { $("#loading").show() },
        ajaxStop: function() { $("#loading").hide() }
    });

    load();

    $('.add').on('click', function () {
        let title = $('#addForm .title');
        let author = $('#addForm .author');
        let isbn = $('#addForm .isbn');

        $.ajax({
            method: 'POST',
            url: url + 'books',
            headers: {
                "Authorization": "Basic " + base64auth,
                "Content-type": "application/json"
            },
            data: JSON.stringify({
                "title": title.val(),
                "author": author.val(),
                "isbn": isbn.val(),
            })
        }).then(load)
            .catch(handleErrors);

        title.val('');
        author.val('');
        isbn.val('');
    });

    function displayBooks(books) {
        for (const book of books) {
            let updateBtn = $('<button class="update">Update</button>').on('click', updateBook);
            let deleteBtn = $('<button class="delete">Delete</button>').on('click', deleteBook);
            let div = $(`<div class="book" data-id="${book._id}">`)
                .append(`<div class="title">Title: <span>${book.title}</span></div>`)
                .append(`<div class="author">Author: <span>${book.author}</span></div>`)
                .append(`<div class="isbn">ISBN: <span>${book.isbn}</span></div>`)
                .append(updateBtn)
                .append(deleteBtn);
            displayDiv.append(div)
        }
    }

    function handleErrors(err) {
        console.log(err);
    }

    function load() {
        displayDiv.empty();
        $.ajax({
            method: 'GET',
            url: url + 'books',
            headers: authHeader
        }).then(displayBooks)
            .catch(handleErrors);
    }

    function updateBook() {
        let id = $(this).parent().attr('data-id');
        let title = $(this).parent().find('.title span');
        let author = $(this).parent().find('.author span');
        let isbn = $(this).parent().find('.isbn span');
        let editBtn = $('<button id="edit">Edit</button>').on('click', edit);
        $('#editBook').empty();

        $('#editBook').append(`<fieldset id="editForm" data-id="${id}">
            <legend>Edit Book</legend>
            <label>Title</label>
            <input type="text" class="title" value="${title.text()}"/>
            <label>Author</label>
            <input type="text" class="author" value="${author.text()}"/>
            <label>ISBN</label>
            <input type="number" class="isbn" value="${isbn.text()}"/>
        </fieldset>`);
        $('#editForm').append(editBtn);
    }

    function edit() {
        let id = $(this).parent().attr('data-id');
        let title = $(this).parent().find('.title').val();
        let author = $(this).parent().find('.author').val();
        let isbn = $(this).parent().find('.isbn').val();
        $.ajax({
            method: 'PUT',
            url: url + `books/${id}`,
            headers: authHeader,
            data: {
                "title": title,
                "author": author,
                "isbn": isbn,
            }
        }).then(load)
            .catch(function () {
                $('#errDiv')
                    .css('display', '')
                    .text('You can edit only books created by you!')
                    .fadeOut(3000)
            });
        $(this).parent().remove();
    }

    function deleteBook() {
        let id = $(this).parent().attr('data-id');
        $.ajax({
            method: 'DELETE',
            url: url + `books/${id}`,
            headers: authHeader
        }).then(load)
            .catch(function () {
                $('#errDiv')
                    .css('display', '')
                    .text('You can delete only books created by you!')
                    .fadeOut(3000)
            })
    }
}