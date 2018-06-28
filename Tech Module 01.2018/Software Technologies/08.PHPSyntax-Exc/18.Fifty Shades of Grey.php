<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php
$index = 0;

for ($row = 1; $row <= 5; $row++) {
    $number = $index;

    for ($col = 1; $col <= 10; $col++) {
        echo "<div style='background-color: rgb($number, $number, $number)'></div>";
        $number += 5;
    }

    $index += 51;
    echo "<br>";
}
?>
</body>
</html>