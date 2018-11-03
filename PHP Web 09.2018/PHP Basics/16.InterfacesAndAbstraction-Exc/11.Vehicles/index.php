<?php
spl_autoload_register();
$vehicles = [];

[$vehicle, $fuel, $consumption] = explode(' ', readline());
$vehicles[$vehicle] = new $vehicle(floatval($fuel), floatval($consumption));
[$vehicle, $fuel, $consumption] = explode(' ', readline());
$vehicles[$vehicle] = new $vehicle(floatval($fuel), floatval($consumption));
$n = intval(readline());

for ($i = 0; $i < $n; $i++){
    [$command, $vehicle, $value] = explode(' ', readline());
    $command = strtolower($command);
    $vehicles[$vehicle]->$command(floatval($value));
}

foreach ($vehicles as $key => $vehicle) {
    $remainingFuel = number_format($vehicle->getFuel(), 2, '.', '');
    echo "$key: {$remainingFuel}" . PHP_EOL;
}