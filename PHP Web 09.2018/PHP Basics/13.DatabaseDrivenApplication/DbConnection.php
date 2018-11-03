<?php

class DbConnection
{
    public static function getConnection() {
        return new PDO('mysql:host=localhost;dbname=php_application', 'root', '',
            [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]);
    }
}