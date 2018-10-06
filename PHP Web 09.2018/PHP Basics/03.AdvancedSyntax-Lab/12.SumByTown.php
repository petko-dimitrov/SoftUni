<?php
$input = explode(', ', readline());
$towns = [];

for ($i = 0; $i < count($input); $i += 2){
    $town = $input[$i];
    $income = intval($input[$i + 1]);

    if (!array_key_exists($town, $towns)) {
        $towns[$town] = 0;
    }

    $towns[$town] += $income;
}

foreach ($towns as $town => $income) {
    echo "$town => $income" . PHP_EOL;
}
