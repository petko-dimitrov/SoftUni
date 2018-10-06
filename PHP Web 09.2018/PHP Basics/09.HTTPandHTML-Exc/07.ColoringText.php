<?php
if (isset($_GET['input'])) {
    $text = $_GET['input'];
    $result = "";

    for ($i = 0; $i < strlen($text); $i++){
        $letter = $text[$i];

        if ($letter == ' ') {
            continue;
        }

        if (ord($letter) % 2 == 0) {
            $result .= "<span style='color:red'>$letter</span> ";
        } else {
            $result .= "<span style='color:blue'>$letter</span> ";
        }
    }

    echo $result;
}
?>

<form>
    <textarea rows="10" name="input"></textarea><br>
    <input type="submit" value="Count words">
</form>
