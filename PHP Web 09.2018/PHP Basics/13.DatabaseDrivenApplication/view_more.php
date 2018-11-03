<?php
spl_autoload_register();
$page_title = "More Info";
$db = DbConnection::getConnection();
$product_obj = new Product($db);
include 'header.php';

if (isset($_GET['id'])) {
    $id = htmlspecialchars($_GET['id']);
    $product = $product_obj->getOne($id);

    if ($product) {
        $date = date('d.m.Y', strtotime($product['created']));
        $modified = date('d.m.Y', strtotime($product['modified']));
        echo '<h1>' . $product['name'] . '</h1>';
        echo '<table class=\'table table-hover table-responsive table-bordered\'>';
        echo '<tr><td>Id</td><td>' . $product['id'] . '</td></tr>';
        echo '<tr><td>Description</td><td>' . $product['description'] . '</td></tr>';
        echo '<tr><td>Price</td><td>&#36;' . $product['price'] . '</td></tr>';
        echo '<tr><td>Category</td><td>' . $product['cname'] . '</td></tr>';
        echo '<tr><td>Date created</td><td>' . $date . '</td></tr>';
        echo '<tr><td>Date modified</td><td>' . $modified . '</td></tr>';
        echo '</table>';
    } else {
        echo 'No product found!';
    }
}

include 'footer.php';