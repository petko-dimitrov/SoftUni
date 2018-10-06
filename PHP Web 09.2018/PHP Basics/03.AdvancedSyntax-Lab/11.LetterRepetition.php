<?php
$input = readline();
$occurrences = [];

for ($i = 0; $i < strlen($input); $i++){
    if (!array_key_exists($input[$i], $occurrences)) {
        $occurrences[$input[$i]] = 0;
    }

    $occurrences[$input[$i]]++;
}

foreach ($occurrences as $letter => $occurrence) {
    echo "$letter -> $occurrence" . PHP_EOL;
}