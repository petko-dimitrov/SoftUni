<?php
spl_autoload_register();
$page_url = "index.php?";
$page_title = "Online Shop";
$db = DbConnection::getConnection();
$product_obj = new Product($db);
$total_rows = $product_obj->countAll();

// page given in URL parameter, default page is one
$page = isset($_GET['page']) ? $_GET['page'] : 1;
// set number of records per page
$records_per_page = 5;
// calculate for the query LIMIT clause
$from_record_num = ($records_per_page * $page) - $records_per_page;

$products = $product_obj->getAll($from_record_num, $records_per_page);
include 'header.php';

echo "<div class='right-button-margin'>";
echo "<a href='create.php' class='btn btn-default pull-left'>Create new product</a>";
echo '</div>';
echo '<table class=\'table table-hover table-responsive table-bordered\'>';
echo '<thead><tr><td>Id</td><td>Name</td><td>Price</td><td>Category</td>
<td>Date created</td><td colspan="3">Actions</td></tr></thead><tbody>';

foreach ($products as $product) {
    $date = date('d.m.Y', strtotime($product['created']));
    echo '<tr>';
    echo '<td>' . $product['id'] . '</td>';
    echo '<td>' . $product['name'] . '</td>';
    echo '<td>&#36;' . $product['price'] . '</td>';
    echo '<td>' . $product['cname'] . '</td>';
    echo '<td>' . $date . '</td>';
    echo '<td><a class=\'btn btn-primary left-margin\' href="view_more.php?id='. $product['id'] .'">More</a> </td>';
    echo '<td><a class=\'btn btn-info left-margin\' href="edit_form.php?id=' . $product['id'] .'">Edit</a> </td>';
    echo '<td><a class=\'btn btn-danger delete-object\' href="delete.php?id=' . $product['id'] .'">Delete</a> </td>';
    echo '</tr>';
}

echo '</tbody></table>';
include_once 'paging.php';
include 'footer.php';
