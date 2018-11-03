<?php
spl_autoload_register();
$numOfSongs = intval(readline());
$songs = [];
$h = 0;
$m = 0;
$s = 0;

for ($i = 0; $i < $numOfSongs; $i++) {

    $input = explode(';', readline());
    $artist = '';

    if (count($input) == 1) {
        $artist = $input[0];
        $title = '';
        $length = '';
    } else if (count($input) == 2) {
        $artist = $input[0];
        $title = $input[1];
        $length = '';
    } else if (count($input) == 3) {
        $artist = $input[0];
        $title = $input[1];
        $length = $input[2];

    }

    try {
        $song = new Song($artist, $title, $length);
        $songs[] = $song;
        echo 'Song added.' . PHP_EOL;
        $s += $song->getSeconds();
        $m += $song->getMinutes();
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
    }
}

$m += intval($s / 60);
$s = $s % 60;
$h += intval($m / 60);
$m = $m % 60;


echo "Songs added: " . count($songs) . PHP_EOL;
echo "Playlist length: " . $h . "h " . sprintf('%02d', $m) . 'm ' . sprintf('%02d', $s) . 's';