<?php
spl_autoload_register();

$name = readline();
$age = intval(readline());
$id = readline();
$date = readline();
$citizen = new Citizen($name, $age, $id, $date);
echo $citizen;