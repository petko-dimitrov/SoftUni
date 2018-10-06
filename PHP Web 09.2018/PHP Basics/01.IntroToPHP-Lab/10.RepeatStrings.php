<?php
$arr = readline();
$arr = explode(' ', $arr);
$result = '';

for ($i = 0; $i < count($arr); $i++){
    for ($j = 0; $j < strlen($arr[$i]); $j++){
        $result .= $arr[$i];
    }
}

echo $result;