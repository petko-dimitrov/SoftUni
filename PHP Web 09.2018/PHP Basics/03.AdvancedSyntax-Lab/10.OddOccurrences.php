<?php
$words = array_map('strtolower', explode(' ', readline()));
$occurrences = [];

foreach ($words as $word) {
    if (!array_key_exists($word, $occurrences)) {
        $occurrences[$word] = 0;
    }

    $occurrences[$word]++;
}

$resultArr = [];

foreach ($occurrences as $word => $occurrence) {
    if ($occurrence % 2 != 0) {
        array_push($resultArr, $word);
    }
}

echo implode(', ',$resultArr);
