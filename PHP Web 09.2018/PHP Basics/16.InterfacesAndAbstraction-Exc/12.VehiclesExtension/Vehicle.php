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
     * @var float
     */
    protected $capacity;

    /**
     * Vehicle constructor.
     * @param float $fuel
     * @param float $capacity
     */
    public function __construct(float $fuel, float $capacity)
    {
        $this->setFuel($fuel);
        $this->setCapacity($capacity);
    }

    /**
     * @return float
     */
    public function getCapacity(): float
    {
        return $this->capacity;
    }

    /**
     * @param float $capacity
     */
    public function setCapacity(float $capacity): void
    {
        $this->capacity = $capacity;
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
     * @throws Exception
     */
    protected function setFuel(float $fuel): void
    {
        if ($fuel < 0) {
            throw new Exception('Fuel must be a positive number');
        }
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