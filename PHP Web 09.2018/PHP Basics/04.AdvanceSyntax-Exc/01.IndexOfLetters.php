<?php
$letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
$input = strtolower(readline());

for ($i = 0; $i < strlen($input); $i++) {
    $index = array_search($input[$i], $letters);
    $letter = $input[$i];
    echo "$letter -> $index" . PHP_EOL;
}