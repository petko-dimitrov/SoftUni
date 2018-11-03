<?php

class Truck extends Vehicle
{
    /**
     * Car constructor.
     * @param float $fuel
     * @param float $consumption
     */
    public function __construct(float $fuel, float $consumption)
    {
        parent::__construct($fuel);
        $this->setConsumption($consumption);
    }

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