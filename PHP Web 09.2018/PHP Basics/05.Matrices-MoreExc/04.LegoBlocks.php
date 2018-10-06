<?php
$rows = intval(readline());
$firstArr = [];
$secondArr = [];

for ($i = 0; $i < $rows; $i++){
    $firstArr[$i] = explode(' ', readline());
}

for ($i = 0; $i < $rows; $i++){
    $secondArr[$i] = explode(' ', readline());
    $secondArr[$i] = array_reverse($secondArr[$i]);
}

$counter = 0;
$isFitting = true;
$rowLength = count($firstArr[0]) + count($secondArr[0]);

for ($row = 0; $row < $rows; $row++){
    for ($col = 0; $col < count($secondArr[$row]); $col++){
        array_push($firstArr[$row], $secondArr[$row][$col]);
    }

    if ($rowLength != count($firstArr[$row])) {
        $isFitting = false;
    }

    $rowLength = count($firstArr[$row]);
    $counter += $rowLength;
}

if ($isFitting) {
    for ($row = 0; $row < $rows; $row++){
        echo '[';
        for ($col = 0; $col < count($firstArr[$row]) - 1; $col++){
            echo $firstArr[$row][$col] . ', ';
        }

        echo $firstArr[$row][count($firstArr[$row]) - 1] . ']' . PHP_EOL;
    }
} else {
    echo "The total number of cells is: $counter";
}
