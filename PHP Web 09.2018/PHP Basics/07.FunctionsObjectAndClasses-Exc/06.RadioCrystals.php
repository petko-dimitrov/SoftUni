<?php
$input = array_map('floatval', explode(', ', readline()));
$targetThickness = array_shift($input);

for ($i = 0; $i < count($input); $i++) {
    $thickness = $input[$i];
    echo "Processing chunk $thickness microns" . PHP_EOL;

    if (isDone($thickness, $targetThickness)) {
        continue;
    }

    $currentThickness = cut($thickness, $targetThickness);
    if ($currentThickness !== $thickness) {
        $thickness = $currentThickness;
        $thickness = transportAndWash($thickness);
        if (isDone($thickness, $targetThickness)) {
            continue;
        }
    }

    $currentThickness = lap($thickness, $targetThickness);
    if ($currentThickness !== $thickness) {
        $thickness = $currentThickness;
        $thickness = transportAndWash($thickness);
        if (isDone($thickness, $targetThickness)) {
            continue;
        }
    }

    $currentThickness = grind($thickness, $targetThickness);
    if ($currentThickness !== $thickness) {
        $thickness = $currentThickness;
        $thickness = transportAndWash($thickness);
        if (isDone($thickness, $targetThickness)) {
            continue;
        }
    }

    $currentThickness = etch($thickness, $targetThickness);
    if ($currentThickness !== $thickness) {
        $thickness = $currentThickness;
        $thickness = transportAndWash($thickness);
        if (isDone($thickness, $targetThickness)) {
            continue;
        }
    }
}

function lap($thickness, $targetThickness)
{
    $counter = 0;
    while ($thickness - 0.2 * $thickness >= $targetThickness) {
        $thickness = $thickness - 0.2 * $thickness;
        $counter++;
    }

    if ($counter > 0) {
        echo "Lap x$counter" . PHP_EOL;
    }
    return $thickness;
}

function cut($thickness, $targetThickness)
{
    $counter = 0;
    while ($thickness / 4 >= $targetThickness) {
        $thickness = $thickness / 4;
        $counter++;
    }
    if ($counter > 0) {
        echo "Cut x$counter" . PHP_EOL;
    }
    return $thickness;
}

function grind($thickness, $targetThickness)
{
    $counter = 0;
    while ($thickness - 20 >= $targetThickness) {
        $thickness -= 20;
        $counter++;
    }
    if ($counter > 0) {
        echo "Grind x$counter" . PHP_EOL;
    }
    return $thickness;
}

function etch($thickness, $targetThickness)
{
    $counter = 0;
    while ($thickness - 2 >= $targetThickness - 1) {
        $thickness -= 2;
        $counter++;
    }
    if ($counter > 0) {
        echo "Etch x$counter" . PHP_EOL;
    }
    return $thickness;
}

function xray($thickness)
{
    $thickness++;
    echo "X-ray x1" . PHP_EOL;
    return $thickness;
}

function transportAndWash($thickness)
{
    echo "Transporting and washing" . PHP_EOL;
    $thickness = floor($thickness);
    return $thickness;
}

function isDone($thickness, $targetThickness)
{
    if ($thickness < $targetThickness) {
        $thickness = xray($thickness);
    }

    if ($thickness == $targetThickness) {
        echo "Finished crystal $targetThickness microns" . PHP_EOL;
        return true;
    }
    return false;
}