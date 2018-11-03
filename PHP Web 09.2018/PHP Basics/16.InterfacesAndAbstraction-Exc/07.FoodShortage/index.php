<?php
spl_autoload_register();
$people = [];
$n = intval(readline());

for ($i = 0; $i < $n; $i++){
    $input = explode(' ', readline());

    if (count($input) == 3) {
        $people[$input[0]] = new Rebel($input[0], intval($input[1]), $input[2]);
    } else {
        $people[$input[0]] = new Citizen($input[0], intval($input[1]), $input[2], $input[3]);
    }
}

$name = readline();

while ($name !== 'End') {
    if (array_key_exists($name, $people)) {
        $people[$name]->buyFood();
    }

    $name = readline();
}

$totalFood = 0;

foreach ($people as $person) {
    $totalFood += $person->getFood();
}

echo $totalFood;