<?php
$n = intval(readline());

for ($i = 1; $i <= $n; $i++){
    $sumOfDigits = 0;
    $number = $i;

    while ($number != 0) {
        $sumOfDigits = $sumOfDigits + $number % 10;
        $number = $number / 10;
    }

    $isSpecial = $sumOfDigits === 5 || $sumOfDigits === 7 || $sumOfDigits === 11;
    if ($isSpecial) {
        echo "$i -> True \n";
    } else {
        echo "$i -> False \n";
    }
}