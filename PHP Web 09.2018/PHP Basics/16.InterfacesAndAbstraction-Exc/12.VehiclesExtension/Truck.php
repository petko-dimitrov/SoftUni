<?php

class Truck extends Vehicle
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
        $this->fuel += $liters * 0.95;
    }

    /**
     * @param float $consumption
     */
    protected function setConsumption(float $consumption): void
    {
        $this->consumption = $consumption + 1.6;
    }
}