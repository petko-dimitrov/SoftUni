<?php
$input = array_map('intval', explode(' ', readline()));
$rows = $input[0];
$cols = $input[1];
$matrix = [];

for ($row = 0; $row < $rows; $row++){
    $input = readline();

    for ($col = 0; $col < $cols; $col++){
        $matrix[$row][$col] = $input[$col];
    }
}

$directions = readline();

for ($i = 0; $i < $rows; $i++){
    $playerRow = array_search('P', array_column($matrix, $i));

    if ($playerRow > -1) {
        $playerCol = $i;
        break;
    }
}

$isDead = false;
$isOut = false;

for ($i = 0; $i < strlen($directions); $i++){
    $matrix[$playerRow][$playerCol] = '.';

    switch ($directions[$i]) {
        case 'L':
            $playerCol--;
            break;
        case 'R':
            $playerCol++;
            break;
        case 'U':
            $playerRow--;
            break;
        case 'D':
            $playerRow++;
            break;
        default:
            break;
    }

    if ($playerCol < 0 || $playerRow < 0 || $playerCol >= $cols || $playerRow >= $rows) {
        $isOut = true;
    } else if ($matrix[$playerRow][$playerCol] == 'B') {
        $isDead = true;
    } else {
        $matrix[$playerRow][$playerCol] = 'P';
    }

    $tempMatrix = $matrix;

    for ($row = 0; $row < $rows; $row++){

        for ($col = 0; $col < $cols; $col++){
            if ($matrix[$row][$col] == 'B') {
                if ($row - 1 >= 0) {
                    if ($matrix[$row - 1][$col] == 'P') {
                        $isDead = true;
                    }
                    $tempMatrix[$row - 1][$col] = 'B';
                }
                if ($row + 1 < $rows) {
                    if ($matrix[$row + 1][$col] == 'P') {
                        $isDead = true;
                    }
                    $tempMatrix[$row + 1][$col] = 'B';
                }
                if ($col - 1 >= 0) {
                    if ($matrix[$row][$col - 1] == 'P') {
                        $isDead = true;
                    }
                    $tempMatrix[$row][$col - 1] = 'B';
                }
                if ($col + 1 < $cols) {
                    if ($matrix[$row][$col + 1] == 'P') {
                        $isDead = true;
                    }
                    $tempMatrix[$row][$col + 1] = 'B';
                }
            }
        }
    }

    $matrix = $tempMatrix;

    if ($isDead || $isOut) {
        break;
    }
}

for ($row = 0; $row < $rows; $row++){
    for ($col = 0; $col < $cols; $col++){
        echo $matrix[$row][$col];
    }

    echo PHP_EOL;
}

if ($isDead) {
    echo "dead: $playerRow $playerCol";
} else {
    if ($playerCol < 0) {
        $playerCol = 0;
    } else if ($playerRow < 0) {
        $playerRow = 0;
    } else if ($playerCol >= $cols) {
        $playerCol--;
    } else {
        $playerRow--;
    }
    echo "won: $playerRow $playerCol";
}