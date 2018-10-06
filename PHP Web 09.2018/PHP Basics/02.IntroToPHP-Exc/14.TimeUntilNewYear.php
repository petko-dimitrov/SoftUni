<?php
$input = readline();
$date = date_parse($input);
$year = $date['year'];
$timestamp = mktime($date['hour'], $date['minute'], $date['second'], $date['month'],
    $date['day'], $year);

$newYear = mktime(0, 0, 0, 1, 1, $year + 1);
$seconds = $newYear - $timestamp;

$lastSundayOfMarch = strtotime("last Sunday of March $year");
$startSummerTime = mktime(3, 0, 0, 3, date($date['day'], $lastSundayOfMarch), $date['year']);
$lastSundayOfOctober = strtotime("last Sunday of October $year");
$endSummerTime = mktime(3, 0, 0, 10, date($date['day'], $lastSundayOfOctober), $date['year']);

if ($startSummerTime <= $timestamp && $timestamp <= $endSummerTime) {
    $seconds -= 3600;
}


$hours = round($seconds / 3600);
$minutes = round($seconds / 60);
$days = round($seconds / 86400);
$remainder = date('G:i:s', $timestamp);

echo "Hours until new year : $hours\nMinutes until new year : $minutes\n";
echo "Seconds until new year : $seconds\nDays:Hours:Minutes:Seconds $days:$remainder";
