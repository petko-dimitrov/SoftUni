<?php
$arr = explode(' ', readline());
$sum = 0;

for ($i = 0; $i < count($arr); $i++){
    $arr[$i] = intval(strrev($arr[$i]));
    $sum += $arr[$i];
}

echo $sum;