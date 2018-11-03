<?php

abstract class SpecialisedSoldier extends PrivateSoldier implements ISpecialisedSoldier
{
    /**
     * @var string
     */
    private $corps;

    public function __construct(string $id, string $firstName, string $lastName, float $salary, string $corps)
    {
        parent::__construct($id, $firstName, $lastName, $salary);
        $this->setCorps($corps);
    }

    /**
     * @return string
     */
    public function getCorps(): string
    {
        return $this->corps;
    }

    /**
     * @param string $corps
     */
    public function setCorps(string $corps): void
    {
        $this->corps = $corps;
    }

    public function __toString()
    {
        return parent::__toString() . PHP_EOL . "Corps: {$this->corps}" . PHP_EOL;
    }
}