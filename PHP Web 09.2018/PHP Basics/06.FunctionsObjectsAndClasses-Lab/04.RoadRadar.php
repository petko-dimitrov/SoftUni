<?php
function getSpeedLimit($area) {
    switch ($area){
        case 'motorway':
            $speedLimit = 130;
        break;
        case 'interstate':
            $speedLimit = 90;
            break;
        case 'city':
            $speedLimit = 50;
            break;
        case 'residential':
            $speedLimit = 20;
            break;
        default:
            break;
    }

    return $speedLimit;
}

function checkSpeed($speed, $limit) {
    $difference = $speed - $limit;

    if ($difference > 0) {
        if ($difference <= 20){
            echo 'speeding';
        } else if ($difference <= 40) {
            echo 'excessive speeding';
        } else {
            echo 'reckless driving';
        }
    }
}

$speed = intval(readline());
$area = readline();
$limit = getSpeedLimit($area);
checkSpeed($speed, $limit);