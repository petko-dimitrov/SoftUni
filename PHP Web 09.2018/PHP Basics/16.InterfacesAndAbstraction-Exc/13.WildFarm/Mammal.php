<?php

abstract class Mammal extends Animal
{
    /**
     * @var string
     */
    protected $livingRegion;

    /**
     * Mammal constructor.
     * @param string $animalName
     * @param string $animalType
     * @param float $animalWeight
     * @param int $foodEaten
     * @param string $livingRegion
     */
    public function __construct(string $animalName, string $animalType, float $animalWeight, string $livingRegion)
    {
        parent::__construct($animalName, $animalType, $animalWeight);
        $this->setLivingRegion($livingRegion);
    }

    /**
     * @param string $livingRegion
     */
    private function setLivingRegion(string $livingRegion): void
    {
        $this->livingRegion = $livingRegion;
    }

    public function __toString()
    {
        return "{$this->animalType}[{$this->animalName}, {$this->animalWeight}, {$this->livingRegion}, {$this->foodEaten}]" . PHP_EOL;
    }
}