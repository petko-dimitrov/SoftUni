<?php
$arr = array_map('intval', explode(' ', readline()));
$bestStart = 0;
$bestLength = 1;
$currentLength = 1;

for ($i = 1; $i < count($arr); $i++) {
    if ($arr[$i] > $arr[$i - 1]) {
        $currentLength++;
    } else  {
        if ($bestLength < $currentLength) {
            $bestLength = $currentLength;
            $bestStart = $i - $bestLength;
        }
        $currentLength = 1;
    }

    if ($i == count($arr) - 1) {
        if ($currentLength > $bestLength) {
            $bestLength = $currentLength;
            $bestStart = $i - $bestLength + 1;
        }
    }
}

for ($i = $bestStart; $i < $bestStart + $bestLength; $i++) {
    echo $arr[$i] . ' ';
}