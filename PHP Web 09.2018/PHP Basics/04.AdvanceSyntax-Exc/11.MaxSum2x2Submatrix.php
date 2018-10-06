<?php
$size = explode(', ', readline());
$rows = intval($size[0]);
$cols = intval($size[1]);
$matrix = [];
$maxSum = PHP_INT_MIN;
$maxRow = 0;
$maxCol = 0;

for ($row = 0; $row < $rows; $row++){
    $matrix[$row] = array_map('intval', explode(', ', readline()));
}

for ($row = 0; $row < $rows - 1; $row++){
    for ($col = 0; $col < $cols - 1; $col++){
        $currentSum = $matrix[$row][$col]
            + $matrix[$row][$col + 1]
            + $matrix[$row + 1][$col]
            + $matrix[$row + 1][$col + 1];

        if ($currentSum > $maxSum) {
            $maxSum = $currentSum;
            $maxRow = $row;
            $maxCol = $col;
        }
    }
}

for ($row = $maxRow; $row < $maxRow + 2; $row++){
    for ($col = $maxCol; $col < $maxCol + 2; $col++){
        echo $matrix[$row][$col] . ' ';
    }
    echo PHP_EOL;
}

echo $maxSum;