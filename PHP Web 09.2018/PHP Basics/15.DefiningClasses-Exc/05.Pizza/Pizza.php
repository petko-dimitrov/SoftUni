<?php

class Pizza
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var int
     */
    private $numOfToppings;
    /**
     * @var Dough
     */
    private $dough;
    /**
     * @var Topping[]
     */
    private $toppings;
    /**
     * @var float
     */
    private $calories;

    /**
     * Pizza constructor.
     * @param string $name
     * @param int $numOfToppings
     * @throws Exception
     */
    public function __construct(string $name, int $numOfToppings)
    {
        $this->setName($name);
        $this->setNumOfToppings($numOfToppings);
        $this->toppings = [];
        $this->calories = 0;
    }

    /**
     * @param string $name
     * @throws Exception
     */
    private function setName(string $name): void
    {
        if (strlen($name) < 1 || strlen($name) > 15) {
            throw new Exception("Pizza name should be between 1 and 15 symbols.");
        }
        $this->name = $name;
    }

    /**
     * @param int $numOfToppings
     * @throws Exception
     */
    private function setNumOfToppings(int $numOfToppings): void
    {
        if ($numOfToppings < 0 || $numOfToppings > 10) {
            throw new Exception('Number of toppings should be in range [0..10].');
        }
        $this->numOfToppings = $numOfToppings;
    }

    public function addDough (Dough $dough): void {
        $this->dough = $dough;
        $this->calories += $dough->getCalories();
    }

    public function addTopping (Topping $topping): void {
        $this->toppings[] = $topping;
        $this->calories += $topping->getCalories();
    }

    public function getCalories() {
        return $this->calories;
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }
}