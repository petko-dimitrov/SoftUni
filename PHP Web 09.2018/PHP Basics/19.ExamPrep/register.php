<?php
require_once 'common.php';
$userRepository = new \TaskManagement\Repository\UserRepository($db);
$userService = new \TaskManagement\Service\UserService($userRepository);
$userHttpHandler = new \TaskManagement\Http\UserHttpHandler($template, $dataBinder);
$userHttpHandler->register($userService, $_POST);