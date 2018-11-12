<?php
require_once 'common.php';
$homeHttpHandler = new \TaskManagement\Http\HomeHttpHandler($template, $dataBinder);
$homeHttpHandler->index();