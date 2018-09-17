function search() {
    let searchVal = $('#searchText').val();
    let matches = $(`ul li:contains(${searchVal})`);
    $('#towns li').css('font-weight', '');
    matches.css('font-weight', 'bold');
    $('#result').text(`${matches.length} matches found.`);
}