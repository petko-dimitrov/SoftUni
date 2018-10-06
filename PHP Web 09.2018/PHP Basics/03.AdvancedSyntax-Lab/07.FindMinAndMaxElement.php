<?php
$size = explode(', ', readline());
$rows = intval($size[0]);
$cols = intval($size[1]);
$matrix = [];

for ($row = 0; $row < $rows; $row++){
    $matrix[$row] = array_map('intval', explode(', ', readline()));
}

$min = $matrix[0][0];
$max = $matrix[0][0];

for ($row = 0; $row < $rows; $row++){
    for ($col = 0; $col < $cols; $col++){
        if ($min > $matrix[$row][$col]) {
            $min = $matrix[$row][$col];
        }

        if ($max < $matrix[$row][$col]) {
            $max = $matrix[$row][$col];
        }
    }
}

echo "Min: $min" . PHP_EOL . "Max: $max";