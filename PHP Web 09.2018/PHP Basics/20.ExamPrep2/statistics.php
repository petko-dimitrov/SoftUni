<?php
require_once 'common.php';

$operationRepository = new \MyMoney\Repository\OperationRepository($db, $dataBinder);
$operationService = new \MyMoney\Service\OperationService($operationRepository);
$operationsHandler = new \MyMoney\Http\OperationHttpHandler($template, $dataBinder);

$operationsHandler->statistics($operationService);