<?php
$text = readline();
$letters = '';
$digits = '';
$others = '';

for ($i = 0; $i < strlen($text); $i++){
    if ((ord($text[$i]) >= 65 && ord($text[$i]) <= 90) ||
        (ord($text[$i]) >= 97 && ord($text[$i]) <= 122)) {
        $letters .= $text[$i];
    } else if (ord($text[$i]) >= 48 && ord($text[$i]) <= 57) {
        $digits .= $text[$i];
    } else {
        $others .= $text[$i];
    }
}

echo "$digits\n$letters\n$others";