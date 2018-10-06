<?php
$arr = array_map('intval', explode(' ', readline()));

while(count($arr) > 1) {
    $newArr = [];

    for ($i = 1; $i < count($arr); $i++){
        array_push($newArr, $arr[$i-1] + $arr[$i]);
    }

    $arr = $newArr;
}

echo $arr[0];
