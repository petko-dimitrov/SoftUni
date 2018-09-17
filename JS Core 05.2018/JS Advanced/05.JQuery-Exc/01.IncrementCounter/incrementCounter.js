function increment(element) {
    $(element).append("<textarea class='counter' value='0' disabled='true'>")
        .append("<button class='btn' id='incrementBtn'>Increment</button>")
        .append("<button class='btn' id='addBtn' >Add</button>")
        .append("<ul class='results'>");

    let value = $("textarea").attr('value');
    $("textarea").val(value);

    $("#incrementBtn").on('click', function () {
        let value = $("textarea").attr('value');
        value++;
        $('textarea').attr('value', value);
        $("textarea").val(value);
    });

    $("#addBtn").on('click', function () {
        let value = $("textarea").attr('value');
        $("ul").append(`<li>${value}</li>`)
        $("textarea").val(value);
    });
}