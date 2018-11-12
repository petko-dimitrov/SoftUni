<?php
session_start();
spl_autoload_register();

$template = new \Core\Template();
$dataBinder = new \Core\DataBinder();
$dbData = parse_ini_file('Config/db.ini');
$pdo = new PDO($dbData['dsn'], $dbData['user'], $dbData['pass'], [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]);
$db = new \Database\PDODatabase($pdo);