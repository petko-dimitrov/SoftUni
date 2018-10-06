<?php
$length = intval(readline());
$sequence = 'ATCGTTAGGG';
$asterisks = 2;
$dashes = 0;
$counter = 0;

for ($i = 1; $i <= $length; $i++) {
    $line = '';
    $line .= str_repeat('*', $asterisks);
    $line .= $sequence[$counter % strlen($sequence)];
    $counter++;
    $line .= str_repeat('-', $dashes);
    $line .= $sequence[$counter % strlen($sequence)];
    $counter++;
    $line .= str_repeat('*', $asterisks);

    if ($i % 4 == 0) {
        $asterisks = 2;
        $dashes = 0;
    } else if ($i % 4 == 1 || $i % 4 == 3){
        $asterisks = 1;
        $dashes = 2;
    } else {
        $asterisks = 0;
        $dashes = 4;
    }

    echo $line . PHP_EOL;
}