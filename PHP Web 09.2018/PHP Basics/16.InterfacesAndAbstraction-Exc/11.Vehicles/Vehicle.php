<?php

abstract class Vehicle
{
    /**
     * @var float
     */
    protected $fuel;
    /**
     * @var float
     */
    protected $consumption;

    /**
     * Vehicle constructor.
     * @param float $fuel
     */
    public function __construct(float $fuel)
    {
        $this->setFuel($fuel);
    }


    /**
     * @return float
     */
    public function getFuel(): float
    {
        return $this->fuel;
    }

    /**
     * @param float $fuel
     */
    protected function setFuel(float $fuel): void
    {
        $this->fuel = $fuel;
    }

    /**
     * @return float
     */
    public function getConsumption(): float
    {
        return $this->consumption;
    }

    /**
     * @param float $consumption
     */
    abstract protected function setConsumption(float $consumption): void;

    abstract public function refuel($liters): void;

    public function drive($distance): void
    {
        $fuelNeeded = $this->consumption * $distance;
        $name = get_class($this);

        if ($fuelNeeded > $this->fuel) {
            echo "{$name} needs refueling" .PHP_EOL;
        } else {
            $this->fuel -= $fuelNeeded;
            echo "{$name} travelled {$distance} km" . PHP_EOL;
        }
    }
}