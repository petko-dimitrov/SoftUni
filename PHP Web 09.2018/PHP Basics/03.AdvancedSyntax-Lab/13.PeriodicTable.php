<?php
$elements = explode(', ', readline());
$occurrences = [];

foreach ($elements as $element) {
    if (!array_key_exists($element, $occurrences)) {
        $occurrences[$element] = 0;
    }

    $occurrences[$element]++;
}

foreach ($occurrences as $el => $occurrence) {
    if ($occurrence == 1) {
        echo $el . ' ';
    }
}

