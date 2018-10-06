<?php
$input = array_map('intval', explode(' ', readline()));
$rows = $input[0];
$cols = $input[1];
$snake = readline();
$shot = array_map('intval', explode(' ', readline()));
$shotRow = $shot[0];
$shotCol = $shot[1];
$shotRadius = $shot[2];
$direction = 0;
$counter = 1;

for ($row = $rows - 1; $row >= 0; $row--){
    if ($direction % 2 == 0) {
        for ($col = $cols - 1; $col >= 0; $col--){
            $matrix[$row][$col] = $snake[$counter % strlen($snake) - 1];
            $counter++;
        }
    } else {
        for ($col = 0; $col < $cols; $col++){
            $matrix[$row][$col] = $snake[$counter % strlen($snake) - 1];
            $counter++;
        }
    }

    $direction++;
}

for ($row = 0; $row < $rows; $row++){

    for ($col = 0; $col < $cols; $col++){
        $distance = sqrt(pow($row - $shotRow, 2) + pow($col - $shotCol, 2));
        if ($distance <= $shotRadius) {
            $matrix[$row][$col] = ' ';
        }
    }
}

for ($row = $rows - 1; $row >= 0; $row--){

    for ($col = 0; $col < $cols; $col++){
        if ($matrix[$row][$col] == ' ') {
            for ($i = $row - 1; $i >= 0; $i--){
                if ($matrix[$i][$col] !== ' '){
                    $matrix[$row][$col] = $matrix[$i][$col];
                    $matrix[$i][$col] = ' ';
                    break;
                }
            }
        }
    }
}

for ($row = 0; $row < $rows; $row++){

    for ($col = 0; $col < $cols; $col++){
        echo $matrix[$row][$col] . ' ';
    }

    echo PHP_EOL;
}