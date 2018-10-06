<?php
$n = intval(readline());
$number = 1;
$sum = 0;

for ($i = 0; $i < $n; $i++){
    $sum += $number;
    echo $number . "\n";
    $number += 2;
}

echo "Sum: $sum";