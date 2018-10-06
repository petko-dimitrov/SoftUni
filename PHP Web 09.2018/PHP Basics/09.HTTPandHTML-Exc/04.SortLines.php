<?php
    if (isset($_GET['lines'])) {
        $sortedLines = explode(PHP_EOL, $_GET['lines']);
        sort($sortedLines);
    }
?>
<form>
  <textarea rows="10" name="lines"><?= implode(PHP_EOL, $sortedLines);
      ?></textarea> <br>
    <input type="submit" value="Sort">
</form>
