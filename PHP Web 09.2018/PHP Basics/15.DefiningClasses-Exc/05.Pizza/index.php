<?php
spl_autoload_register();

[$type, $name, $numOfToppings] = explode(' ', readline());
try {
    $pizza = new Pizza($name, intval($numOfToppings));
} catch (Exception $e) {
    echo $e->getMessage();
    return;
}

[$name, $type, $technique, $weight] = explode(' ', readline());
try {
    $dough = new Dough($type, $technique, floatval($weight));
} catch (Exception $e) {
    echo $e->getMessage();
    return;
}
$pizza->addDough($dough);

$input = readline();

while ($input !== 'END') {
    [$type, $name, $weight] = explode(' ', $input);
    try {
        $topping = new Topping($name, floatval($weight));
    } catch (Exception $e) {
        echo $e->getMessage();
        return;
    }

    $pizza->addTopping($topping);
    $input = readline();
}

$calories = number_format($pizza->getCalories(), 2 , '.', '');
echo "{$pizza->getName()} - $calories Calories.";