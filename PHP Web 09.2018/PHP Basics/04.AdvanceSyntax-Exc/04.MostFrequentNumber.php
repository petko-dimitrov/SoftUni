<?php
$numbers = array_map('intval', explode(' ', readline()));
$uniqueNumbers = [];


for ($i = 0; $i < count($numbers); $i++){
    if (!array_key_exists($numbers[$i], $uniqueNumbers)) {
        $uniqueNumbers[$numbers[$i]] = 0;
    }
    $uniqueNumbers[$numbers[$i]]++;
}

$max = 0;
$mostFrequent = null;

foreach ($uniqueNumbers as $key => $value){
    if ($value > $max) {
        $max = $value;
        $mostFrequent = $key;
    }
}

echo $mostFrequent;