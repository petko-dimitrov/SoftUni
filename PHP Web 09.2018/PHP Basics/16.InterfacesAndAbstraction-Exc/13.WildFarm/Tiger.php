<?php

class Tiger extends Feline
{
    public function __construct(string $animalName, string $animalType, float $animalWeight, string $livingRegion)
    {
        parent::__construct($animalName, $animalType, $animalWeight, $livingRegion);
    }

    public function makeSound(): void
    {
        echo "ROAAR!!!" . PHP_EOL;
    }

    /**
     * @param $type
     * @param $quantity
     * @throws Exception
     */
    public function eatFood($type, $quantity): void {
        $food = new $type($quantity);

        if (get_class($food) !== 'Meat') {
            throw new Exception("{$this->animalType}s are not eating that type of food!");
        }

        $this->foodEaten += $food->getQuantity();
    }
}