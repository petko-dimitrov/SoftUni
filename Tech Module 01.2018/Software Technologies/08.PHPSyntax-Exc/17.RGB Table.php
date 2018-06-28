<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
	<style>
		table * {
			border: 1px solid black;
			width: 50px;
			height: 50px;
		}
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
<?php
$number = 51;

for ($row = 1; $row <= 5; $row++) {
    echo "<tr>";

    for ($col = 1; $col <= 3; $col++) {
        if($col == 1){
            echo "<td style='background-color: rgb($number, 0, 0)'></td>";
        }
        else if($col == 2){
            echo "<td style='background-color: rgb(0, $number, 0)'></td>";
        }
        else {
            echo "<td style='background-color: rgb(0, 0, $number)'></td>";
        }
    }

    echo "</tr>";
    $number += 51;
}
?>
</table>
</body>
</html>