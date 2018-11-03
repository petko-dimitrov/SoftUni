<?php
spl_autoload_register();
$driver = readline();
$ferrari = new Ferrari($driver);
echo $ferrari;