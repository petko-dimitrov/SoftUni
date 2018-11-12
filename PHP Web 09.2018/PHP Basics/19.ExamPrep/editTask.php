<?php
require_once 'common.php';
$taskRepository = new \TaskManagement\Repository\TaskRepository($db, $dataBinder);
$taskService = new \TaskManagement\Service\TaskService($taskRepository);
$categoryRepository = new \TaskManagement\Repository\CategoryRepository($db);
$categoryService = new \TaskManagement\Service\CategoryService($categoryRepository);
$taskHttpHandler = new \TaskManagement\Http\TaskHttpHandler($template, $dataBinder);
$userRepository = new \TaskManagement\Repository\UserRepository($db);
$userService = new \TaskManagement\Service\UserService($userRepository);
$taskHttpHandler->editTask($taskService, $categoryService, $userService, $_POST, $_GET);