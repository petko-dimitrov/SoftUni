<?php
$input = array_map('floatval', explode(', ', readline()));
list($x1, $y1, $x2, $y2, $x3, $y3) = $input;
$distance1To2 = calcDistance($x1, $y1, $x2, $y2);
$distance2To3 = calcDistance($x2, $y2, $x3, $y3);
$distance1To3 = calcDistance($x1, $y1, $x3, $y3);

$totalDistance = $distance1To2 + $distance2To3;
$result = "1->2->3: $totalDistance";

    if ($totalDistance > $distance1To3 + $distance2To3) {
        $totalDistance = $distance1To3 + $distance2To3;
        $result = "1->3->2: $totalDistance";
    }

    if ($totalDistance > $distance1To2 + $distance1To3){
        $totalDistance = $distance1To2 + $distance1To3;
        $result = "2->1->3: $totalDistance";
    }

    if ($totalDistance > $distance2To3 + $distance1To3){
        $totalDistance = $distance2To3 + $distance1To3;
        $result = "2->3->1: $totalDistance";
    }

echo $result;

function calcDistance($x1, $y1, $x2, $y2) {
    $distance = sqrt(pow($x2 - $x1, 2) + pow($y2 - $y1, 2));
    return $distance;
}
