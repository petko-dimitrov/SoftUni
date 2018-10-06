<?php
$number = floatval(readline());
$commands = explode(', ', readline());

foreach ($commands as $command) {
    switch ($command) {
        case 'chop': $number = chopNum($number); break;
        case 'dice': $number = dice($number); break;
        case 'spice': $number = spice($number); break;
        case 'bake': $number = bake($number); break;
        case 'fillet': $number = fillet($number); break;
        default: break;
    }

    echo $number . PHP_EOL;
}


function chopNum($number) {
    return $number / 2;
}

function dice($number) {
    return sqrt($number);
}

function spice($number) {
    return ++$number;
}

function bake($number) {
    return $number * 3;
}

function fillet($number) {
    return $number * 0.8;
}