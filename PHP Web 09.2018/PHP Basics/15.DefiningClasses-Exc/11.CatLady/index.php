<?php
spl_autoload_register();
$cats = [];

$input = readline();

while ($input !== 'End') {
    [$breed, $name, $value] = explode(' ', $input);
    $cats[$name] = new $breed($name, intval($value));
    $input = readline();
}

$catName = readline();
echo $cats[$catName];