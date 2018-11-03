<?php
spl_autoload_register();
$creatures = [];
$input = explode(' ', readline());
while ($input[0] !== 'End') {
    $creature = null;

    if (count($input) === 2) {
        $creatures[] = new Robot($input[0], $input[1]);
    } else {
        $creatures[] = new Citizen($input[0], intval($input[1]), $input[2]);
    }

    $input = explode(' ', readline());
}

$endId = readline();

foreach ($creatures as $creature) {
    echo $creature->identify($endId);
}