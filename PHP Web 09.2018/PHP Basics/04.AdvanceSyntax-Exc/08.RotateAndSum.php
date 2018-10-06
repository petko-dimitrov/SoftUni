<?php
$arr = array_map('intval', explode(' ', readline()));
$k = intval(readline());
$sumArr = [];

for ($i = 0; $i < count($arr); $i++){
    array_push($sumArr, 0);
}

for ($i = 0; $i < $k; $i++){
    $newArr = [];
    $newArr[0] = $arr[count($arr) - 1];

    for ($j = 1; $j < count($arr); $j++){
        $newArr[$j] = $arr[$j - 1];
    }

    for ($s = 0; $s < count($sumArr); $s++){
        $sumArr[$s] += $newArr[$s];
    }

    $arr = $newArr;
}

echo implode(' ', $sumArr);
