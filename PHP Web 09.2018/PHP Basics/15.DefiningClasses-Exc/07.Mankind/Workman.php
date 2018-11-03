<?php

class Workman extends Human
{
    /**
     * @var float
     */
    private $weekSalary;
    /**
     * @var int
     */
    private $workHoursPerDay;

    public function __construct(string $firstName, string $lastName, float $weekSalary, int $workHoursPerDay)
    {
        parent::__construct($firstName, $lastName);
        $this->setLastName($lastName);
        $this->setWeekSalary($weekSalary);
        $this->setWorkHoursPerDay($workHoursPerDay);
    }

    /**
     * @return float
     */
    public function getWeekSalary(): float
    {
        return $this->weekSalary;
    }

    /**
     * @param float $weekSalary
     * @throws Exception
     */
    private function setWeekSalary(float $weekSalary): void
    {
        if ($weekSalary <= 10) {
            throw new Exception('Expected value mismatch!Argument: weekSalary');
        }
        $this->weekSalary = $weekSalary;
    }

    /**
     * @return int
     */
    public function getWorkHoursPerDay(): int
    {
        return $this->workHoursPerDay;
    }

    /**
     * @param int $workHoursPerDay
     * @throws Exception
     */
    private function setWorkHoursPerDay(int $workHoursPerDay): void
    {
        if ($workHoursPerDay < 1 || $workHoursPerDay > 12) {
            throw new Exception('Expected value mismatch!Argument: workHoursPerDay');
        }
        $this->workHoursPerDay = $workHoursPerDay;
    }

    /**
     * @param string $lastName
     * @throws Exception
     */
    public function setLastName(string $lastName): void
    {
        if (strlen($lastName) < 4) {
            throw new Exception('Expected length more than 3 symbols!Argument: lastName');
        }
        $this->lastName = $lastName;
    }

    public function calcMoneyPerHour () {
        return $this->weekSalary / ($this->workHoursPerDay * 7);
    }

    public function __toString()
    {
        $names = parent::__toString();
        $salary = number_format($this->weekSalary, 2, '.', '');
        $hours = number_format($this->workHoursPerDay, 2, '.', '');
        $hourly = number_format($this->calcMoneyPerHour(), 2, '.', '');

        return $names . "Week Salary: {$salary}\nHours per day: {$hours}\nSalary per hour: {$hourly}";
    }
}