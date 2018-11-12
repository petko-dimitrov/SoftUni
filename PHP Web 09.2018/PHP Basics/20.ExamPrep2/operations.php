<?php
require_once 'common.php';

$operationRepository = new \MyMoney\Repository\OperationRepository($db, $dataBinder);
$operationService = new \MyMoney\Service\OperationService($operationRepository);
$homeHandler = new \MyMoney\Http\HomeHttpHandler($template, $dataBinder);
$homeHandler->operations($operationService);