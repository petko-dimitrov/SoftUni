<?php
$n = intval(readline());
$k = intval(readline());
$arr = [1];
$sum = 0;
$start = 0;

for ($i = 1; $i < $n; $i++){
    $end = $start - $k + 1;

    if ($end < 0) {
        $end = 0;
    }

    for ($j = $start; $j >= $end; $j--){
        $sum += $arr[$j];
    }

    array_push($arr, $sum);
    $sum = 0;
    $start = $i;
}

echo implode(' ', $arr);