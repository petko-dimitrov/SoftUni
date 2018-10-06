<?php
$input = explode(', ', readline());
$n = intval($input[0]);
$pattern = $input[1];
$matrix = [];

if ($pattern == 'A') {
    for ($row = 1; $row <= $n; $row++){
        $matrix[$row - 1] = [];
        $current = $row;

        for ($col = 1; $col <= $n; $col++){
            if ($col == 1) {
                $matrix[$row - 1][$col - 1] = $row;
            } else {
                $matrix[$row - 1][$col - 1] = $current;
            }

            $current += $n;
        }
    }
} else {
    $current = 1;

    for ($col = 0; $col < $n; $col++){
        if ($col % 2 == 0) {
            for ($row = 0; $row < $n; $row++){
                $matrix[$row][$col] = $current;
                $current++;
            }
        } else {
            for ($row = $n - 1; $row >= 0; $row--){
                $matrix[$row][$col] = $current;
                $current++;
            }
        }
    }
}

for ($i = 0; $i < $n; $i++){
    for ($j = 0; $j < $n; $j++){
        echo $matrix[$i][$j] . ' ';
    }
    echo PHP_EOL;
}
