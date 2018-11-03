<?php

interface IPrivateSoldier
{
    /**
     * @param float $salary
     */
    public function setSalary(float $salary): void;
    public function getSalary(): float;
}