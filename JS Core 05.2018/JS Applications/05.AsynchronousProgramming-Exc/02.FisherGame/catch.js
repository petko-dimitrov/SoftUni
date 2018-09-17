function attachEvents() {
    let url = 'https://baas.kinvey.com/appdata/kid_rJE9U8747/';
    let user = 'Pesho';
    let password = '123';
    let base64auth = btoa(user + ':' + password);
    let authHeader = {"Authorization": "Basic " + base64auth};
    let displayDiv = $('#catches');

    $('.load').on('click', function () {
        $.ajax({
            method: 'GET',
            url: url + 'biggestCatches',
            headers: authHeader
        }).then(displayAllCatches)
            .catch(handleErrors)
    });

    $('.add').on('click', function () {
        let angler = $('#addForm .angler');
        let weight = $('#addForm .weight');
        let species = $('#addForm .species');
        let location = $('#addForm .location');
        let bait = $('#addForm .bait');
        let captureTime = $('#addForm .captureTime');
        $.ajax({
            method: 'POST',
            url: url + 'biggestCatches',
            headers: {
                "Authorization": "Basic " + base64auth,
                "Content-type": "application/json"
            },
            data: JSON.stringify({
                "angler": angler.val(),
                "weight": Number(weight.val()),
                "species": species.val(),
                "location": location.val(),
                "bait": bait.val(),
                "captureTime": Number(captureTime.val())
            })
        }).then()
            .catch(handleErrors);

        angler.val('');
        weight.val('');
        species.val('');
        location.val('');
        bait.val('');
        captureTime.val('');
    });

    function displayAllCatches(catches) {
        displayDiv.empty();
        
        for (const fish of catches) {
            let updateBtn = $('<button class="update">Update</button>').on('click', updateCatch);
            let deleteBtn = $('<button class="delete">Delete</button>').on('click', deleteCatch);
            let catchDiv = $(`<div class="catch" data-id="${fish._id}">`);
            catchDiv
                .append('<label>Angler</label>')
                .append(`<input type="text" class="angler" value="${fish.angler}"/>`)
                .append('<label>Weight</label>')
                .append(`<input type="number" class="weight" value="${fish.weight}"/>`)
                .append('<label>Species</label>')
                .append(`<input type="text" class="species" value="${fish.species}"/>`)
                .append('<label>Location</label>')
                .append(`<input type="text" class="location" value="${fish.location}"/>`)
                .append('<label>Bait</label>')
                .append(`<input type="text" class="bait" value="${fish.bait}"/>`)
                .append('<label>Capture Time</label>')
                .append(`<input type="number" class="captureTime" value="${fish.captureTime}"/>`)
                .append(updateBtn)
                .append(deleteBtn);
            displayDiv.append(catchDiv)
        }
    }

    function updateCatch() {
        let id = $(this).parent().attr('data-id');
        let angler = $(this).parent().find('input.angler');
        let weight = $(this).parent().find('input.weight');
        let species = $(this).parent().find('input.species');
        let location = $(this).parent().find('input.location');
        let bait = $(this).parent().find('input.bait');
        let captureTime = $(this).parent().find('input.captureTime');

        $.ajax({
            method: 'PUT',
            url: url + `biggestCatches/${id}`,
            headers: {
                "Authorization": "Basic " + base64auth,
                "Content-type": "application/json"
            },
            data: JSON.stringify({
                "angler": angler.val(),
                "weight": Number(weight.val()),
                "species": species.val(),
                "location": location.val(),
                "bait": bait.val(),
                "captureTime": Number(captureTime.val())
            })
        }).then()
            .catch(handleErrors);
    }
    
    function deleteCatch() {
        let id = $(this).parent().attr('data-id');
        $.ajax({
            method: 'DELETE',
            url: url + `biggestCatches/${id}`,
            headers: {
                "Authorization": "Basic " + base64auth,
                "Content-type": "application/json"
            }
        }).then()
            .catch(handleErrors);
    }

    function handleErrors(err) {
        console.log(err);
    }
}