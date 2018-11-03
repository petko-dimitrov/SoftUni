<?php

abstract class Animal
{
    /**
     * @var string
     */
    protected $animalName;
    /**
     * @var string
     */
    protected $animalType;
    /**
     * @var double
     */
    protected $animalWeight;
    /**
     * @var int
     */
    protected $foodEaten;

    /**
     * Animal constructor.
     * @param string $animalName
     * @param string $animalType
     * @param float $animalWeight
     */
    public function __construct(string $animalName, string $animalType, float $animalWeight)
    {
        $this->setAnimalName($animalName);
        $this->setAnimalType($animalType);
        $this->setAnimalWeight($animalWeight);
        $this->foodEaten = 0;
    }

    /**
     * @param string $animalName
     */
    private function setAnimalName(string $animalName): void
    {
        $this->animalName = $animalName;
    }

    /**
     * @param string $animalType
     */
    private function setAnimalType(string $animalType): void
    {
        $this->animalType = $animalType;
    }

    /**
     * @param float $animalWeight
     */
    private function setAnimalWeight(float $animalWeight): void
    {
        $this->animalWeight = $animalWeight;
    }

    /**
     * @param int $foodEaten
     */
    private function setFoodEaten(int $foodEaten): void
    {
        $this->foodEaten = $foodEaten;
    }

    abstract public function makeSound(): void;

    public function eatFood($type, $quantity): void {
        $food = new $type($quantity);
        $this->foodEaten += $food->getQuantity();
    }
}