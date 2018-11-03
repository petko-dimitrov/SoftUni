<?php

class Smartphone implements ICallable, IBrowsable
{

    public function browse($url)
    {
        if (preg_match('/[0-9]/', $url)) {
            return 'Invalid URL!' . PHP_EOL;
        }
        return "Browsing: {$url}!" . PHP_EOL;
    }

    public function call($number)
    {
        if (preg_match('/[^0-9]/', $number)) {
            return 'Invalid number!' . PHP_EOL;
        }
        return "Calling... $number" . PHP_EOL;
    }
}