<?php

class Topping
{
    /**
     * @var string
     */
    private $type;
    /**
     * @var float
     */
    private $weight;
    /**
     * @var float
     */
    private $modifier;
    /**
     * @var float
     */
    private $calories;

    /**
     * Topping constructor.
     * @param string $type
     * @param float $weight
     * @throws Exception
     */
    public function __construct(string $type, float $weight)
    {
        $this->setType($type);
        $this->setWeight($weight);
        $this->setModifier();
        $this->setCalories();
    }

    /**
     * @param string $type
     * @throws Exception
     */
    private function setType(string $type): void
    {
        $typeToLower = strtolower($type);
        if ($typeToLower !== 'meat' && $typeToLower !== 'veggies' && $typeToLower !== 'cheese' && $typeToLower !== 'sauce') {
            throw new Exception("Cannot place $type on top of your pizza.");
        }
        $this->type = $type;
    }

    /**
     * @param float $weight
     * @throws Exception
     */
    private function setWeight(float $weight): void
    {
        if ($weight < 1 || $weight > 50) {
            throw new Exception("{$this->type} weight should be in the range [1..50].");
        }
        $this->weight = $weight;
    }

    private function setModifier(): void
    {
        $this->modifier = 2;
        $type = strtolower($this->type);
        switch ($type) {
            case 'meat':
                $this->modifier *= 1.2;
                break;
            case 'veggies':
                $this->modifier *= 0.8;
                break;
            case 'cheese':
                $this->modifier *= 1.1;
                break;
            case 'sauce':
                $this->modifier *= 0.9;
                break;
            default:
                break;
        }
    }

    public function getCalories() {
        return $this->calories;
    }

    private function setCalories()
    {
        $this->calories = $this->modifier * $this->weight;
    }
}