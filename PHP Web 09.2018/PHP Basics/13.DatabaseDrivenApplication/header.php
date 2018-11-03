<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title><?php echo $page_title; ?></title>

    <!-- Latest compiled and minified Bootstrap CSS -->
    <link rel="stylesheet"
          href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- our custom CSS -->
    <link rel="stylesheet" href="libs/css/custom.css" />

</head>
<body>
<!-- container -->
<div class="container">

<?php
// show page header
echo "<div class='page-header'>
                <h1>{$page_title}</h1>
            </div>";
?>