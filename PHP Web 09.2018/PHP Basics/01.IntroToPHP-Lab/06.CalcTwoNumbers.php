<?php
$firstNum = readline();
$secondNum = readline();
$command = readline();

switch ($command) {
    case 'sum':
        $result = $firstNum + $secondNum;
        break;
    case 'subtract':
        $result = $firstNum - $secondNum;
        break;
    case 'divide':
        if ($firstNum == 0 || $secondNum == 0) {
            $result = 'Cannot divide by zero';
        } else {
            $result = $firstNum / $secondNum;
        }
        break;
    case 'multiply':
        $result = $firstNum * $secondNum;
        break;
    default:
        $result = 'Wrong operation supplied';
        break;
}

echo $result;