<?php
$input = array_map('intval', explode(' ', readline()));
$rows = $input[0];
$cols = $input[1];
$letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
$matrix = [];

for ($row = 0; $row < $rows; $row++){
    $palindrome = str_repeat($letters[$row], 3);

    for ($col = 0; $col < $cols; $col++){
        $letter = $letters[$row + $col];
        $palindrome[1] = $letter;
        $matrix[$row][$col] = $palindrome;
    }
}

for ($row = 0; $row < $rows; $row++){

    for ($col = 0; $col < $cols; $col++){
        echo $matrix[$row][$col] . ' ';
    }

    echo PHP_EOL;
}
