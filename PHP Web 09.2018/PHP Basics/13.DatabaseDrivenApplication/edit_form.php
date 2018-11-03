<?php
spl_autoload_register();
$page_title = "Edit Product";
include 'header.php';
include 'footer.php';
$db = DbConnection::getConnection();
$category_obj = new Category($db);
$product_obj = new Product($db);

if (isset($_GET['id'])) {
    $product_id = htmlspecialchars($_GET['id']);
    $product = $product_obj->getOne($product_id);

    if ($_POST) {
        $id = $_POST['id'];
        $name = $_POST['name'];
        $price = $_POST['price'];
        $description = $_POST['description'];
        $cat_id = $_POST['category'];
        $product_obj->editProduct($id, $name, $price, $description, $cat_id);
        echo "<div class='alert alert-success alert-dismissable'>";
        echo "Product was updated.";
        echo "</div>";
        //header('Location: index.php');
    }
}
?>
<form method="post">
    <input type="hidden" name="id" value="<?=$product['id']?>">
    <table class='table table-hover table-responsive table-bordered'>
        <tr>
            <td>Name</td>
            <td><input type="text" class='form-control' name="name" value="<?=$product['name']?>"></td>
        </tr>
        <tr>
            <td>Price</td>
            <td><input type="text" class='form-control' name="price" value="<?=$product['price']?>"></td>
        </tr>
        <tr>
            <td>Description</td>
            <td><textarea name="description" class='form-control' cols="30" rows="10"> <?=$product['description']?></textarea></td>
        </tr>
        <tr>
            <td>Category</td>
            <td><select name="category" class='form-control'>
                    <option></option>
                    <?php foreach($category_obj->getAll() as $category): ?>
                        <?php $selected = $product['cid']==$category['id']?'selected':'';?>
                        <option value="<?=$category['id']?>" <?=$selected?>><?=$category['name']?></option>
                    <?php endforeach; ?>
                </select></td>
        </tr>
        <tr>
            <td><div class='right-button-margin'>
                    <a href='index.php' class='btn btn-default pull-left'>Read Products</a>
                </div></td>
            <td><input type="submit" value="Edit" class="btn btn-primary"></td>
        </tr>
    </table>
</form>