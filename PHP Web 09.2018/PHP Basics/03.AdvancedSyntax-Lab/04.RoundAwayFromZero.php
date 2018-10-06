<?php
$arr = explode(' ', readline());

foreach ($arr as $number) {
    $rounded = round(floatval($number), 0, PHP_ROUND_HALF_UP);
    echo sprintf('%s => %d', $number, $rounded) . PHP_EOL;
}