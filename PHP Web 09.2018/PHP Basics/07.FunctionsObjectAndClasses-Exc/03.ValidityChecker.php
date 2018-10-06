<?php
$input = array_map('intval', explode(', ', readline()));
list($x1, $y1, $x2, $y2) = $input;
distanceIsValid($x1, $y1, 0, 0);
distanceIsValid($x2, $y2, 0, 0);
distanceIsValid($x1, $y1, $x2, $y2);


function distanceIsValid ($x1, $y1, $x2, $y2) {
    $distance = sqrt(pow($x2 - $x1, 2) + pow($y2 - $y1, 2));
    echo "{{$x1}, {$y1}} to {{$x2}, {$y2}} ";

    if (ctype_digit(strval($distance))) {
        echo "is valid" . PHP_EOL;
    } else {
        echo "is invalid" . PHP_EOL;
    }
}