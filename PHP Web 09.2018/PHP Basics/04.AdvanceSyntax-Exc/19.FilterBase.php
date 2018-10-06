<?php
$ages = [];
$salaries = [];
$positions = [];
$input = explode(' -> ', readline());

while ($input[0] !== 'filter base') {
    $name = $input[0];

    if (ctype_digit($input[1]) && intval($input[1]) > 0) {
        $ages[$name] = intval($input[1]);
    } else if(is_numeric($input[1]) && floatval($input[1]) > 0) {
        $salaries[$name] = floatval($input[1]);
    } else {
        $positions[$name] = $input[1];
    }

    $input = explode(' -> ', readline());
}

$filter = readline();

switch ($filter) {
    case 'Age':
        foreach ($ages as $name => $age) {
            echo "Name: $name" . PHP_EOL . "Age: $age" . PHP_EOL . str_repeat('=', 20) . PHP_EOL;
        }
        break;
    case 'Salary':
        foreach ($salaries as $name => $salary) {
            echo "Name: $name" . PHP_EOL . "Salary: " . number_format($salary, 2, '.', '') . PHP_EOL . str_repeat('=', 20) . PHP_EOL;
        }
        break;
    case 'Position':
        foreach ($positions as $name => $position) {
            echo "Name: $name" . PHP_EOL . "Position: $position" . PHP_EOL . str_repeat('=', 20) . PHP_EOL;
        }
        break;
    default:
        break;
}
