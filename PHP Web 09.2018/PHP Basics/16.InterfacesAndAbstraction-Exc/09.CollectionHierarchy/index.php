<?php
spl_autoload_register();

$words = explode(' ', readline());
$numOfRemoves = intval(readline());
$addCollection = new AddCollection();
$addRemoveCollection = new AddRemoveCollection();
$myList = new MyList();

printAdd($addCollection, $words);
printAdd($addRemoveCollection, $words);
printAdd($myList, $words);
printRemove($addRemoveCollection, $numOfRemoves);
printRemove($myList, $numOfRemoves);

function printAdd($collection, $words) {
    foreach ($words as $word) {
        echo $collection->add($word) . ' ';
    }
    echo PHP_EOL;
}

function printRemove($collection, $numOfRemoves) {
    for ($i = 0; $i < $numOfRemoves; $i++){
        echo $collection->remove() . ' ';
    }
    echo PHP_EOL;
}