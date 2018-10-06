<?php
$size = explode(' ', readline());
$rows = intval($size[0]);
$cols = intval($size[1]);
$matrix = [];
$maxSum = PHP_INT_MIN;
$maxRow = 0;
$maxCol = 0;

for ($row = 0; $row < $rows; $row++){
    $matrix[$row] = array_map('intval', explode(' ', readline()));
}

for ($row = 0; $row < $rows - 2; $row++){
    for ($col = 0; $col < $cols - 2; $col++){
        $currentSum = 0;
        for ($i = $row; $i < $row + 3; $i++){
            for ($j = $col; $j < $col + 3; $j++){
                $currentSum += $matrix[$i][$j];
            }
        }

        if ($currentSum > $maxSum) {
            $maxSum = $currentSum;
            $maxRow = $row;
            $maxCol = $col;
        }
    }
}

echo 'Sum = ' . $maxSum . PHP_EOL;

for ($row = $maxRow; $row < $maxRow + 3; $row++){
    for ($col = $maxCol; $col < $maxCol + 3; $col++){
        echo $matrix[$row][$col] . ' ';
    }
    echo PHP_EOL;
}