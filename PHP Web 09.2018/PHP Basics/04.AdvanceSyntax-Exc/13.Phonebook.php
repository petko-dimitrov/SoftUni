<?php
$input = explode(' ', readline());
$phonebook = [];

while($input[0] != 'END') {
    $command = $input[0];
    $name = $input[1];
    if (array_key_exists(2, $input)) {
        $number = $input[2];
    }

    if ($command == 'A') {
        $phonebook[$name] = $number;
    } else if ($command == 'S') {
        if (!array_key_exists($name, $phonebook)) {
            echo "Contact $name does not exist." . PHP_EOL;
        } else {
            echo "$name -> $phonebook[$name]" . PHP_EOL;
        }
    }
    $input = explode(' ', readline());
}