<?php
$firstArr = array_map('intval', explode(' ', readline()));
$secondArr = array_map('intval', explode(' ', readline()));
$length1 = count($firstArr);
$length2 = count($secondArr);
$biggerArrLength = max($length1, $length2);

for ($i = 0; $i < $biggerArrLength; $i++){
    $result = $firstArr[$i % $length1] + $secondArr[$i % $length2];
    echo $result . ' ';
}