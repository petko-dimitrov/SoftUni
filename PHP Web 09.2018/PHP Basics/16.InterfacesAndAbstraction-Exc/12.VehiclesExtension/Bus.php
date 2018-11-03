<?php

class Bus extends Vehicle
{
    public function __construct(float $fuel, float $consumption, float $capacity)
    {
        parent::__construct($fuel, $capacity);
        $this->setConsumption($consumption);
    }

    /**
     * @param float $consumption
     */
    protected function setConsumption(float $consumption): void
    {
        $this->consumption = $consumption + 1.4;
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

    public function driveempty($distance)
    {
        $this->consumption -= 1.4;
        $this->drive($distance);
        $this->consumption += 1.4;
    }
}