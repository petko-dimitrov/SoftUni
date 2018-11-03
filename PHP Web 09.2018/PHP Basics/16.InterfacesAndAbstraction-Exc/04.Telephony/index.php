<?php
spl_autoload_register();
$numbers = explode(' ', readline());
$urls = explode(' ', readline());
$phone = new Smartphone();

foreach ($numbers as $number) {
    echo $phone->call($number);
}

foreach ($urls as $url) {
    echo $phone->browse($url);
}