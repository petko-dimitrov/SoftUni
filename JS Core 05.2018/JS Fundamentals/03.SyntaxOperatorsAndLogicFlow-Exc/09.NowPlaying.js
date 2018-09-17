function showSong(input) {
    let song = input[0];
    let artist = input[1];
    let duration = input[2];

    console.log(`Now Playing: ${artist} - ${song} [${duration}]`);
}

showSong(['Number One', 'Nelly', '4:09']);