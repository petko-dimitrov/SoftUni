<?php
require_once 'common.php';
$taskRepository = new \TaskManagement\Repository\TaskRepository($db, $dataBinder);
$taskService = new \TaskManagement\Service\TaskService($taskRepository);
$taskHttpHandler = new \TaskManagement\Http\TaskHttpHandler($template, $dataBinder);

$taskHttpHandler->deleteTask($taskService, $_GET);