<?php
require_once 'common.php';

$operationRepository = new \MyMoney\Repository\OperationRepository($db, $dataBinder);
$operationService = new \MyMoney\Service\OperationService($operationRepository);
$operationHandler = new \MyMoney\Http\OperationHttpHandler($template, $dataBinder);
$operationHandler->deleteOperation($operationService, $_GET);