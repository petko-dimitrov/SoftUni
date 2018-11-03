<?php
spl_autoload_register();

[$username, $type, $points, $level] = explode(' | ', readline());
$hero = new $type($username, floatval($points), intval($level));
echo $hero;