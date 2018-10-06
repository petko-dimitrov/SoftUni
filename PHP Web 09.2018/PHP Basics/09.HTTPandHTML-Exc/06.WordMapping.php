<form>
    <textarea rows="10" name="input"></textarea><br>
    <input type="submit" value="Count words">
</form>

<?php
if (isset($_GET['input'])) {
    $words = array_filter(array_map('strtolower', preg_split('/[^A-Za-z]+/', $_GET['input'])));
    $wordsCount = [];
    foreach ($words as $word) {
        if (!array_key_exists($word, $wordsCount)) {
            $wordsCount[$word] = 0;
        }
        $wordsCount[$word]++;
    }

    $table = "<table border='2'>";
    foreach ($wordsCount as $key => $value){
        $table .= "<tr><td>$key</td><td>$value</td></tr>";
    }
    $table .= "</table>";
    echo $table;
}
?>