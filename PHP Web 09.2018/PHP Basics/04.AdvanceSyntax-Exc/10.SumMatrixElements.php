<?php
$size = explode(', ', readline());
$rows = intval($size[0]);
$cols = intval($size[1]);
$matrix = [];
$sum = 0;

for ($row = 0; $row < $rows; $row++){
    $matrix[$row] = array_map('intval', explode(', ', readline()));
}

for ($row = 0; $row < $rows; $row++){
    for ($col = 0; $col < $cols; $col++){
        $sum += $matrix[$row][$col];
    }
}

echo $rows . PHP_EOL . $cols . PHP_EOL . $sum;
