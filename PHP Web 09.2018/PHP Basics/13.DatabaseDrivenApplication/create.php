<?php
spl_autoload_register();
$page_title = "Create Product";
$db = DbConnection::getConnection();
$category_obj = new Category($db);
$product_obj = new Product($db);

if ($_POST) {
    $name = $_POST['name'];
    $price = $_POST['price'];
    $description = $_POST['description'];
    $cat_id = $_POST['category'];
    $product_obj->createProduct($name, $price, $description, $cat_id);
    echo "<div class='alert alert-success'>Product was created.</div>";
    //header('Location: index.php');
}

include 'header.php';
include 'create_form.php';
include 'footer.php';