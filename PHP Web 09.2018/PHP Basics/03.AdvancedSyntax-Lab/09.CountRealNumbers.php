<?php
$numbers = explode(' ', readline());
asort($numbers);
$occurrences = [];

foreach ($numbers as $number) {
    if (!array_key_exists($number, $occurrences)) {
        $occurrences[$number] = 0;
    }
    $occurrences[$number]++;
}

foreach ($occurrences as $number => $occurrence) {
    echo "$number -> $occurrence" . PHP_EOL;
}
