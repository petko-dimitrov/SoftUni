<?php


class Cat extends Feline
{
    /**
     * @var string
     */
    private $breed;

    public function __construct(string $animalName, string $animalType, float $animalWeight, string $livingRegion, string $breed)
    {
        parent::__construct($animalName, $animalType, $animalWeight, $livingRegion);
        $this->setBreed($breed);
    }

    /**
     * @param string $breed
     */
    public function setBreed(string $breed): void
    {
        $this->breed = $breed;
    }

    public function makeSound(): void
    {
        echo "Meowwww" . PHP_EOL;
    }

    public function __toString()
    {
        return "{$this->animalType}[{$this->animalName}, {$this->breed}, {$this->animalWeight}, {$this->livingRegion}, {$this->foodEaten}]" . PHP_EOL;
    }
}