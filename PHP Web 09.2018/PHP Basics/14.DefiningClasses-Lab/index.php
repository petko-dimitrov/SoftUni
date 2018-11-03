<?php
spl_autoload_register();

$car = new Vehicle(2, 'orange');
//$car->setDoors(4);
//echo $car->__get('numberDoors') . PHP_EOL;
$car->paint('blue');
//print_r($car);
$audi = new Car(4, 'red', 'Audi', 'A4', 2016);
//print_r($audi);
$audi->paint('green');
//print_r($audi);
//$audi->color = 'black'; -> should throw an error
//$myCar->setDoors(15);   -> should throw an error
