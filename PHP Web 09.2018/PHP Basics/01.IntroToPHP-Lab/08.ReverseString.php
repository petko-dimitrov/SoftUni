<?php
$command = readline();

while($command !== 'end') {
    $reversed = strrev($command);
    echo "$command = $reversed \n";
    $command = readline();
}