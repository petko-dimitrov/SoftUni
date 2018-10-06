<?php
$number = readline();
$avg = calcAvg($number);

while ($avg <= 5) {
    $number .= '9';
    $avg = calcAvg($number);
}

echo $number;

function calcAvg($str) {
    $sum = 0;

    for ($i = 0; $i < strlen($str); $i++){
        $sum += intval($str[$i]);
    }

    $avg = $sum / strlen($str);
    return $avg;
}