<?php

interface IBirthday
{
    public function setBirthday($date): void;
    public function checkYear($year): bool;
}