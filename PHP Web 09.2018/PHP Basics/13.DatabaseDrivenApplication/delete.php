<?php
spl_autoload_register();
$db = DbConnection::getConnection();
$product_obj = new Product($db);

if (isset($_GET['id'])) {
    $id = htmlspecialchars($_GET['id']);

    if ($_POST) {
        $product_obj->deleteProduct($id);
    }

    header('Location: index.php');
}