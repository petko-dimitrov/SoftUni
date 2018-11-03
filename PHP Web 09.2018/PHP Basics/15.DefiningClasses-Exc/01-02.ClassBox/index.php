<?php
spl_autoload_register();
$length = floatval(readline());
$width = floatval(readline());
$height = floatval(readline());

try {
    $cube = new Box($length, $width, $height);
} catch (Exception $e) {
    echo $e->getMessage();
    return;
}
$area = number_format($cube->calcArea(), 2, '.', '');
$lateralArea = number_format($cube->calcLateralArea(), 2, '.', '');
$volume = number_format($cube->calcVolume(), 2, '.', '');
echo "Surface Area - $area" . PHP_EOL;
echo "Lateral Surface Area - $lateralArea" . PHP_EOL;
echo "Volume - $volume" . PHP_EOL;