<?php
$n = intval(readline());
$arr = [];

for ($i = 0; $i < $n; $i++){
    array_push($arr, intval(readline()));
}

for ($i = count($arr) - 1; $i >= 0; $i--){
    echo $arr[$i] . ' ';
}