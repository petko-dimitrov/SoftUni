<?php
function getDay ($day) {
    switch ($day) {
        case 'monday': echo 1; break;
        case 'tuesday': echo 2; break;
        case 'wednesday': echo 3; break;
        case 'thursday': echo 4; break;
        case 'friday': echo 5; break;
        case 'saturday': echo 6; break;
        case 'sunday': echo 7; break;
        default: echo 'Invalid day!';
    }
}

$input = strtolower(readline());
getDay($input);