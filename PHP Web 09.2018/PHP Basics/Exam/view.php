<?php
require_once 'common.php';

$bookRepository = new \App\Repository\BookRepository($db, $dataBinder);
$bookService = new \App\Service\BookService($bookRepository);
$bookHandler = new \App\Http\BookHttpHandler($template, $dataBinder);
$bookHandler->view($bookService, $_GET);