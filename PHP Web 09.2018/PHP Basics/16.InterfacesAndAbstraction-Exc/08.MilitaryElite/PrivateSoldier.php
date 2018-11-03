<?php

class PrivateSoldier extends Soldier implements IPrivateSoldier
{
    /**
     * @var float
     */
    private $salary;

    public function __construct(string $id, string $firstName, string $lastName, float $salary)
    {
        parent::__construct($id, $firstName, $lastName);
        $this->setSalary($salary);
    }

    /**
     * @param float $salary
     */
    public function setSalary(float $salary): void
    {
        $this->salary = $salary;
    }

    public function getSalary(): float
    {
        return $this->salary;
    }

    public function __toString()
    {
        $formattedSalary = number_format($this->salary, 2, '.', '');
        return parent::__toString() . " Salary: {$formattedSalary}";
    }
}