<?php
$number = intval(readline());
$end = 987;
$arr = [];

if ($number < $end) {
    $end = $number;
}

for ($i = 100; $i <= $end; $i++){
    $currentNum = $i;
    $thirdDigit = $currentNum % 10;
    $currentNum /= 10;
    $secondDigit = $currentNum % 10;
    $currentNum /= 10;
    $firstDigit = $currentNum % 10;

    if ($firstDigit !== $secondDigit && $secondDigit !== $thirdDigit && $firstDigit !== $thirdDigit) {
        array_push($arr, $i);
    }
}

if (count($arr) == 0) {
    echo 'no';
} else {
    echo join(', ', $arr);
}
