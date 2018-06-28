<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
$number = 0;
$color = "";

for ($row = 1; $row <= 5; $row++) {
    for ($col = 1; $col <= 5; $col++) {
        if ($col == 1 || $row == 1 || $row == 5) {
            $number = 1;
            $color = " style='background-color: blue'";
        } else {
            $number = 0;
            $color = "";
        }
        echo "<button$color>$number</button>";
    }
    echo "<br>";
}

for ($row = 1; $row <= 4; $row++) {
    for ($col = 1; $col <= 5; $col++) {
        if ($col == 5 || $row == 4) {
            $number = 1;
            $color = " style='background-color: blue'";
        } else {
            $number = 0;
            $color = "";
        }
        echo "<button$color>$number</button>";
    }
    echo "<br>";
}
?>
</body>
</html>