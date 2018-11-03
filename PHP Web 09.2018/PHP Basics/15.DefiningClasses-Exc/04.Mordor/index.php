<?php
spl_autoload_register();
$happiness = 0;

$input = array_map('strtolower', explode(',', readline()));

foreach ($input as $item) {
    $happiness += FoodFactory::getFoodPoints($item);
}

echo $happiness . PHP_EOL;
echo MoodFactory::getMood($happiness);