<?php
require_once 'common.php';

$bookRepository = new \App\Repository\BookRepository($db, $dataBinder);
$bookService = new \App\Service\BookService($bookRepository);
$genreRepository = new \App\Repository\GenreRepository($db);
$genreService = new \App\Service\GenreService($genreRepository);
$userRepository = new \App\Repository\UserRepository($db);
$userService = new \App\Service\UserService($userRepository);
$bookHandler = new \App\Http\BookHttpHandler($template, $dataBinder);
$bookHandler->editBook($bookService, $genreService, $userService, $_POST, $_GET);