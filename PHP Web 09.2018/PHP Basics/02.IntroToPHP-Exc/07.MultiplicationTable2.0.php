<?php
$number = intval(readline());
$multiplier = intval(readline());

for ($i = $multiplier; $i <= 10; $i++){
    $result = $number * $i;
    echo "$number X $i = $result\n";
}

if ($multiplier > 10) {
    $result = $number * $multiplier;
    echo "$number X $multiplier = $result";
}