<?php
class DecimalNumber {
    public $number;

    function __construct($number) {
        $this->number = $number;
    }

    function printReverse() {
        echo strrev($this->number);
    }
}

$input = readline();
$num = new DecimalNumber($input);
$num->printReverse();