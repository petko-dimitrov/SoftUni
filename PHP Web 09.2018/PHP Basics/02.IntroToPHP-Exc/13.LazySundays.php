<?php
$month = readline();
$date = "2018-$month-1";
$arrDate = date_parse($date);
$month = $arrDate['month'];
$daysOfMonth = cal_days_in_month(CAL_GREGORIAN, $month, 2018);
$currentDate = "2018-$month-1";
$endDate = "2018-$month-$daysOfMonth";

if ($month < 10) {
    $month = '0' . $month;
}

while (strtotime($currentDate) <= strtotime($endDate)) {
    if (date('l', strtotime($currentDate)) == 'Sunday') {
        $arrDate = date_parse($currentDate);
        $day = $arrDate['day'];
        echo $day . "rd $month, 2018\n";
    }

    $currentDate = date("Y-m-d", strtotime("+1 day", strtotime($currentDate)));
}