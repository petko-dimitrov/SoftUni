<?php
require_once 'common.php';

$userRepository = new \App\Repository\UserRepository($db);
$userService = new \App\Service\UserService($userRepository);
$userHandler = new \App\Http\UserHttpHandler($template, $dataBinder);
$userHandler->login($userService, $_POST);