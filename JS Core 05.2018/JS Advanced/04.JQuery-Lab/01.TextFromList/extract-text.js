function extractText() {
    let arr = $('ul li').toArray()
        .map(li => li.textContent).join(', ');
    $('#result').text(arr);
}
