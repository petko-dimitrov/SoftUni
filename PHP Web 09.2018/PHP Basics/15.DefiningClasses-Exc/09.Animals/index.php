<?php
spl_autoload_register();
$type = readline();

while ($type !== 'Beast!') {
    $input = explode(' ', readline());

    try {
        switch ($type) {
            case 'Dog':
            $animal = new Dog($input[0], intval($input[1]), $input[2]);
            echo $animal;
                break;
            case 'Cat':
                $animal = new Cat($input[0], intval($input[1]), $input[2]);
                echo $animal;
                break;
            case 'Frog':
                $animal = new Frog($input[0], intval($input[1]), $input[2]);
                echo $animal;
                break;
            case 'Kitten':
                $animal = new Kitten($input[0], intval($input[1]), 'Female');
                echo $animal;
                break;
            case 'Tomcat':
                $animal = new Tomcat($input[0], intval($input[1]), 'Male');
                echo $animal;
                break;
            default:
                echo "Invalid input!" . PHP_EOL;
                break;
        }

    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
    }

    $type = readline();
}