<?php
spl_autoload_register();

$peopleInput = preg_split('/[;=]/', readline());
$productsInput = preg_split('/[;=]/', readline(), -1, PREG_SPLIT_NO_EMPTY);
$people = [];
$products = [];

for ($i = 0; $i < count($peopleInput) - 1; $i+=2){
    try {
        $name = $peopleInput[$i];
        $money = $peopleInput[$i+1];
        $people[$name] = new Person($name, floatval($money));
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
        return;
    }

}

for ($i = 0; $i < count($productsInput); $i+=2){
    $name = $productsInput[$i];
    $cost = $productsInput[$i+1];
    $products[$name] = new Product($name, floatval($cost));
}

$input = explode(' ', readline());

while ($input[0] != 'END') {
    if (count($input) < 1) {
        $input = explode(' ', readline());
        continue;
    }

    $personName = $input[0];
    $productName = $input[1];

    if ($people[$personName]->getMoney() < $products[$productName]->getCost()) {
        echo "$personName can't afford $productName" . PHP_EOL;
    } else {
        echo "$personName bought $productName" . PHP_EOL;
        $people[$personName]->addToBag($productName);
        $people[$personName]->reduceMoney($products[$productName]->getCost());
    }

    $input = explode(' ', readline());
}

foreach ($people as $person) {
    echo $person->getName() . " - ";

    if (count($person->getBagOfProducts()) > 0) {
        echo implode(',', $person->getBagOfProducts()) . PHP_EOL;
    } else {
        echo 'Nothing bought' . PHP_EOL;
    }
}