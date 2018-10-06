<?php
$groupSize = intval(readline());
$package = readline();
$totalPrice = 0;

if ($groupSize <= 50) {
    $hall = 'Small Hall';
    $totalPrice += 2500;
} else if($groupSize <= 100) {
    $hall = 'Terrace';
    $totalPrice += 5000;
} else if($groupSize <= 120) {
    $hall = 'Great Hall';
    $totalPrice += 7500;
} else {
    echo 'We do not have an appropriate hall.';
    return;
}

switch ($package) {
    case 'Normal':
        $totalPrice += 500;
        $totalPrice *= 0.95;
        break;
    case 'Gold':
        $totalPrice += 750;
        $totalPrice *= 0.9;
        break;
    case 'Platinum':
        $totalPrice += 1000;
        $totalPrice *= 0.85;
        break;
}

$pricePerPerson = round($totalPrice / $groupSize, 2);
echo "We can offer you the $hall\nThe price per person is $pricePerPerson$";