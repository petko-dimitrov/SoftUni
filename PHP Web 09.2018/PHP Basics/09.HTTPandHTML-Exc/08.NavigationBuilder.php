<?php
if (isset($_GET['categories']) && isset($_GET['tags']) && isset($_GET['months'])) {
    $categories = explode(', ', $_GET['categories']);
    $tags = explode(', ', $_GET['tags']);
    $months = explode(', ', $_GET['months']);

    $nav1 = "<h2>Categories</h2><ul>";
    $nav2 = "<h2>Tags</h2><ul>";
    $nav3 = "<h2>Months</h2><ul>";

    foreach ($categories as $item) {
        $nav1 .= "<li>$item</li>";
    }

    foreach ($tags as $item) {
        $nav2 .= "<li>$item</li>";
    }

    foreach ($months as $item) {
        $nav3 .= "<li>$item</li>";
    }


    $nav1 .= "</ul>";
    $nav2 .= "</ul>";
    $nav3 .= "</ul>";
    echo $nav1;
    echo $nav2;
    echo $nav3;
}
?>

<form>
    Categories: <input type="text" name="categories"><br />
    Tags: <input type="text" name="tags"><br />
    Months: <input type="text" name="months"><br />
    <input type="submit" value="Submit">
</form>
