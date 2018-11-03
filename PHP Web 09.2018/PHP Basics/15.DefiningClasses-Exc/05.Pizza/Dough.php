<?php

class Dough
{
    /**
     * @var string
     */
    private $flourType;
    /**
     * @var string
     */
    private $bakingTechnique;
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
     * Dough constructor.
     * @param string $flourType
     * @param string $bakingTechnique
     * @param float $weight
     * @throws Exception
     */
    public function __construct(string $flourType, string $bakingTechnique, float $weight)
    {
        $this->setFlourType($flourType);
        $this->setBakingTechnique($bakingTechnique);
        $this->setWeight($weight);
        $this->setModifier();
        $this->setCalories();
    }

    /**
     * @param string $flourType
     * @throws Exception
     */
    private function setFlourType(string $flourType): void
    {
        $flourType = strtolower($flourType);
        if ($flourType !== 'white' && $flourType !== 'wholegrain') {
            throw new Exception('Invalid type of dough.');
        }
        $this->flourType = $flourType;
    }

    /**
     * @param string $bakingTechnique
     * @throws Exception
     */
    private function setBakingTechnique(string $bakingTechnique): void
    {
        $bakingTechnique = strtolower($bakingTechnique);
        if ($bakingTechnique !== 'crispy' && $bakingTechnique !== 'chewy' && $bakingTechnique !== 'homemade') {
            throw new Exception('Invalid type of dough.');
        }
        $this->bakingTechnique = $bakingTechnique;
    }

    /**
     * @param float $weight
     * @throws Exception
     */
    private function setWeight(float $weight): void
    {
        if ($weight < 1 || $weight > 200) {
            throw new Exception('Dough weight should be in the range [1..200].');
        }
        $this->weight = $weight;
    }

    private function setModifier(): void {
        $this->modifier = 2;

        if ($this->flourType === 'white') {
            $this->modifier *= 1.5;
        }

        if ($this->bakingTechnique === 'crispy') {
            $this->modifier *= 0.9;
        } else if ($this->bakingTechnique === 'chewy') {
            $this->modifier *= 1.1;
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