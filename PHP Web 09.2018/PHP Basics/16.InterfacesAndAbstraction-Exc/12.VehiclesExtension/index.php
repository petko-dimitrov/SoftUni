<?php
spl_autoload_register();
$vehicles = [];

for ($i = 0; $i < 3; $i++){
    [$vehicle, $fuel, $consumption, $capacity] = explode(' ', readline());
    try {
        $vehicles[$vehicle] = new $vehicle(floatval($fuel), floatval($consumption), floatval($capacity));
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
    }
}

$n = intval(readline());

for ($i = 0; $i < $n; $i++){
    [$command, $vehicle, $value] = explode(' ', readline());
    $command = strtolower($command);
    try {
        $vehicles[$vehicle]->$command(floatval($value));
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
    }
}

foreach ($vehicles as $key => $vehicle) {
    $remainingFuel = number_format($vehicle->getFuel(), 2, '.', '');
    echo "$key: {$remainingFuel}" . PHP_EOL;
}