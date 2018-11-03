<?php

class Car extends Vehicle
{
    /**
     * Car constructor.
     * @param float $fuel
     * @param float $consumption
     * @param float $capacity
     */
    public function __construct(float $fuel, float $consumption, float $capacity)
    {
        parent::__construct($fuel, $capacity);
        $this->setConsumption($consumption);
    }

    /**
     * @param $liters
     * @throws Exception
     */
    public function refuel($liters): void
    {
        if ($this->fuel + $liters > $this->capacity) {
            throw new Exception("Cannot fit fuel in tank");
        }
        $this->fuel += $liters;
    }

    /**
     * @param float $consumption
     */
    protected function setConsumption(float $consumption): void
    {
        $this->consumption = $consumption + 0.9;
    }
}