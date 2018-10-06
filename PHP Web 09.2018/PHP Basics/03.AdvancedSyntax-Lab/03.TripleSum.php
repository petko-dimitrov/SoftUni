<?php
$arr = array_map('intval', explode(' ', readline()));
$count = 0;

for ($i = 0; $i < count($arr) - 1; $i++){
    for ($j = $i + 1; $j < count($arr); $j++){
        foreach ($arr as $number) {
            if ($arr[$i] + $arr[$j]  == $number) {
                echo sprintf('%d + %d == %d', $arr[$i], $arr[$j], $number) . PHP_EOL;
                $count++;
            }
        }
    }
}

if ($count === 0) {
    echo 'No';
}
