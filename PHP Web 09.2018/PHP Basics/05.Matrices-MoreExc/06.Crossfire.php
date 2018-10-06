<?php
$input = array_map('intval', explode(' ', readline()));
$rows = $input[0];
$cols = $input[1];
$matrix = [];
$counter = 1;

for ($row = 0; $row < $rows; $row++) {
    for ($col = 0; $col < $cols; $col++) {
        $matrix[$row][$col] = $counter;
        $counter++;
    }
}

$command = explode(' ', readline());

while ($command[0] !== 'Nuke') {
    $row = intval($command[0]);
    $col = intval($command[1]);
    $radius = intval($command[2]);

    for ($c = $col - $radius; $c < $col + $radius; $c++) {
        $matrix[$row][$c] = ' ';
    }

    for ($r = $row - $radius; $r < $row + $radius; $r++) {
        $matrix[$r][$col] = ' ';
    }

    for ($row = 0; $row < $rows; $row++) {
        for ($col = 0; $col < $cols - 1; $col++) {
            if ($matrix[$row][$col] == ' ') {
                $matrix[$row][$col] = $matrix[$row][$col + 1];
                $matrix[$row][$col + 1] = ' ';
            }
        }
    }

    $command = explode(' ', readline());
}

for ($row = 0; $row < count($matrix); $row++) {

    for ($col = 0; $col < count($matrix[$row]); $col++) {
        if (isset($matrix[$row][$col])) {
            echo $matrix[$row][$col] . ' ';
        }
    }

    echo PHP_EOL;
}