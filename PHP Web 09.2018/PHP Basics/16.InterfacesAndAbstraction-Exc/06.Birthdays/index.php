<?php
spl_autoload_register();
$creatures = [];

$input = explode(' ', readline());
while ($input[0] !== 'End') {
    $creature = $input[0];

    if (count($input) === 3) {
        $creatures[] = new $creature($input[1], $input[2]);
    } else {
        $creatures[] = new Citizen(intval($input[1]), $input[2], $input[3], $input[4]);
    }

    $input = explode(' ', readline());
}

$searchYear = intval(readline());

foreach ($creatures as $creature) {
    if (method_exists($creature, 'checkYear') && $creature->checkYear($searchYear)) {
        echo $creature->getBirthday() . PHP_EOL;
    }
}