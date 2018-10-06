<?php
if (isset($_GET['text'])) {
    $words = array_map('trim', preg_split('/\W+/', $_GET['text']));
    $allCapitalWords = array_filter($words, function ($a) {
        return strtoupper($a) == $a;
    });
}
?>

<form>
    <textarea rows="10" name="text"><?= implode(', ', $allCapitalWords);
        ?></textarea><br>
    <input type="submit" value="Extract">
</form>