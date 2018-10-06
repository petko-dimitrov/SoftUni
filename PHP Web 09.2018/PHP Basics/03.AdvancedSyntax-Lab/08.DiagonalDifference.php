<?php
$n = intval(readline());
$matrix = [];

for ($row = 0; $row < $n; $row++){
    $matrix[$row] = array_map('intval', explode(' ', readline()));
}

$primarySum = 0;
$secondarySum = 0;

for ($row = 0; $row < $n; $row++){
    $primarySum += $matrix[$row][$row];
    $secondarySum += $matrix[$row][$n - $row - 1];
}

$difference = abs($primarySum - $secondarySum);
echo $difference;