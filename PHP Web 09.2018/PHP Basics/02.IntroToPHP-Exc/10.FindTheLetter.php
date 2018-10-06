<?php
$text = readline();
$arr = explode(' ', readline());
$letter = $arr[0];
$position = intval($arr[1]);
$count = 0;

for ($i = 0; $i < strlen($text); $i++){
    if ($text[$i] == $letter) {
        $count++;
        if ($count === $position) {
            echo $i;
            break;
        }
    }
}

if ($count < $position) {
    echo 'Find the letter yourself!';
}



