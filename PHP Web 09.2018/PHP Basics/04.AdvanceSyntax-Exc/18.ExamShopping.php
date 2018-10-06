<?php
$products = [];
$input = explode(' ', readline());

while ($input[0] !== 'shopping') {
    $product = $input[1];
    $quantity = intval($input[2]);

    if (!array_key_exists($product, $products)) {
        $products[$product] = 0;
    }

    $products[$product] += $quantity;
    $input = explode(' ', readline());
}

$input = explode(' ', readline());

while ($input[0] !== 'exam') {
    $product = $input[1];
    $quantity = intval($input[2]);

    if (!array_key_exists($product, $products)) {
        echo "$product doesn't exist" . PHP_EOL;
    } else {
        if ($products[$product] === 0) {
            echo "$product out of stock" . PHP_EOL;
        } else if ($products[$product] < $quantity) {
            $products[$product] = 0;
        } else {
            $products[$product] -= $quantity;
        }
    }

    $input = explode(' ', readline());
}

foreach ($products as $product => $quantity) {
    if ($quantity !== 0) {
        echo "$product -> $quantity" . PHP_EOL;
    }
}