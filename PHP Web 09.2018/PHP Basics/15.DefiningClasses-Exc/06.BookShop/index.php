<?php
spl_autoload_register();
$author = readline();
$title = readline();
$price = floatval(readline());
$type = readline();

try {
    switch ($type) {
        case 'STANDARD':
            $book = new Book($author, $title, $price);
            break;
        case 'GOLD':
            $book = new GoldenEditionBook($author, $title, $price);
            break;
        default:
            throw new Exception('Type is not valid!');
            break;
    }

    echo 'OK' . PHP_EOL;
    echo $book->getPrice();
} catch (Exception $e) {
    echo $e->getMessage();
}
