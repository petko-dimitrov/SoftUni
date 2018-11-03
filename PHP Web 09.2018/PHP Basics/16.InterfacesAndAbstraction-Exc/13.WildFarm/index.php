<?php
spl_autoload_register();

$input = explode(' ', readline());
$counter = 0;

while ($input[0] !== 'End') {
    if ($counter % 2 == 0) {
        $type = $input[0];
        $name = $input[1];
        $weight = doubleval($input[2]);
        $area = $input[3];

        if (count($input) == 5) {
            $breed = $input[4];
            $animal = new $type($name, $type, $weight, $area, $breed);
        } else {
            $animal = new $type($name, $type, $weight, $area);
        }

        $animal->makeSound();
    } else {
        $type = $input[0];
        $quantity = intval($input[1]);
        try {
            $animal->eatFood($type, $quantity);
        } catch (Exception $e) {
            echo $e->getMessage() . PHP_EOL;
        }
        echo $animal;
    }

    $counter++;
    $input = explode(' ', readline());
}