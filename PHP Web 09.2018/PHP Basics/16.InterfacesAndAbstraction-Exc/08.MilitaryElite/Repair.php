<?php

class Repair
{
    /**
     * @var string
     */
    private $partName;
    /**
     * @var int
     */
    private $hoursWorked;

    /**
     * Repair constructor.
     * @param string $partName
     * @param int $hoursWorked
     */
    public function __construct(string $partName, int $hoursWorked)
    {
        $this->setPartName($partName);
        $this->setHoursWorked($hoursWorked);
    }


    /**
     * @return string
     */
    public function getPartName(): string
    {
        return $this->partName;
    }

    /**
     * @param string $partName
     */
    private function setPartName(string $partName): void
    {
        $this->partName = $partName;
    }

    /**
     * @return int
     */
    public function getHoursWorked(): int
    {
        return $this->hoursWorked;
    }

    /**
     * @param int $hoursWorked
     */
    private function setHoursWorked(int $hoursWorked): void
    {
        $this->hoursWorked = $hoursWorked;
    }
}