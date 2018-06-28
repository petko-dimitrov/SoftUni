<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $num = intval($_GET['num']);
        $num1 = 1;
        $num2 = 1;
        $num3 = 2;

        echo $num1 . ' ';
        echo $num2 . ' ';
        echo $num3 . ' ';

        for ($i = 3; $i < $num; $i++) {
            $current = $num1 + $num2 + $num3;
            $num1 = $num2;
            $num2 = $num3;
            $num3 = $current;

            echo $current . ' ';
        }
    }
    ?>
</body>
</html>