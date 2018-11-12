<?php
require_once 'common.php';

$operationRepository = new \MyMoney\Repository\OperationRepository($db, $dataBinder);
$operationService = new \MyMoney\Service\OperationService($operationRepository);
$userRepository = new \MyMoney\Repository\UserRepository($db);
$userService = new \MyMoney\Service\UserService($userRepository);
$reasonRepository = new \MyMoney\Repository\ReasonRepository($db);
$reasonService = new \MyMoney\Service\ReasonService($reasonRepository);

$operationHandler = new \MyMoney\Http\OperationHttpHandler($template, $dataBinder);
$operationHandler->addOperation($operationService, $reasonService, $userService, $_POST);