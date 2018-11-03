<?php
spl_autoload_register();

list($firstName, $lastName, $facultyNumber) = explode(' ', readline());

try {
    $student = new Student($firstName, $lastName, $facultyNumber);
} catch (Exception $e) {
    echo $e->getMessage();
    return;
}

list($firstName, $lastName, $salary, $hours) = explode(' ', readline());

try {
    $worker = new Workman($firstName, $lastName, floatval($salary), intval($hours));
} catch (Exception $e) {
    echo $e->getMessage();
    return;
}

echo $student . PHP_EOL . PHP_EOL;
echo $worker;