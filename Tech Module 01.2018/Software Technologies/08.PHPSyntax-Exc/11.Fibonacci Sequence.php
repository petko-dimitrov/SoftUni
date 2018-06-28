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
        $current = 1;
        $previous = 0;
        $temp = 1;

        echo $current . ' ';

        for ($i = 2; $i <= $num; $i++) {
            $current = $temp + $previous;
            $previous = $temp;
            $temp = $current;
            echo $current . ' ';
        }
    }
    ?>
</body>
</html>