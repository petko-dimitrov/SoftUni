<?php
$text = readline();
$length = strlen($text);

for ($i = $length; $i < 20; $i++){
    $text .= '*';
}

if ($length > 20) {
    echo substr($text, 0, 20);
} else {
    echo $text;
}