<?php
    if (isset($_GET['name']) && isset($_GET['phone']) && isset($_GET['age']) && isset($_GET['address'])) {
        $name = $_GET['name'];
        $phone = $_GET['phone'];
        $age = $_GET['age'];
        $address = $_GET['address'];
        $table = "<table border='2'>";
        $table .= "<tr><td style='background-color: orange'>Name</td><td>$name</td></tr>";
        $table .= "<tr><td style='background-color: orange'>Phone number</td><td>$phone</td></tr>";
        $table .= "<tr><td style='background-color: orange'>Age</td><td>$age</td></tr>";
        $table .= "<tr><td style='background-color: orange'>Address</td><td>$address</td></tr></table>";
        echo $table;
    }
?>

<form>
Name: <input type="text" name="name"><br />
    Phone: <input type="text" name="phone"><br />
    Age: <input type="text" name="age"><br />
    Address: <input type="text" name="address"><br />
    <input type="submit" value="Submit">
</form>