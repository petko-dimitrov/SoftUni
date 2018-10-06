<?php
class Car {
    private $model;
    private $fuelAmount;
    private $fuelCostPerKm;
    private $distanceTraveled;

    public function __construct(string $model, float $fuelAmount, float $fuelCostPerKm)
    {
        $this->setModel($model);
        $this->setFuelAmount($fuelAmount);
        $this->setFuelCostPerKm($fuelCostPerKm);
        $this->distanceTraveled = 0;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @return float
     */
    public function getFuelAmount(): float
    {
        return $this->fuelAmount;
    }

    /**
     * @return float
     */
    public function getFuelCostPerKm(): float
    {
        return $this->fuelCostPerKm;
    }

    /**
     * @return float
     */
    public function getDistanceTraveled(): float
    {
        return $this->distanceTraveled;
    }

    /**
     * @param string $model
     */
    public function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * @param float $fuelAmount
     */
    public function setFuelAmount(float $fuelAmount): void
    {
        $this->fuelAmount = $fuelAmount;
    }

    /**
     * @param float $fuelCostPerKm
     */
    public function setFuelCostPerKm(float $fuelCostPerKm): void
    {
        $this->fuelCostPerKm = $fuelCostPerKm;
    }

    /**
     * @param float $distanceTraveled
     */
    public function setDistanceTraveled(float $distanceTraveled): void
    {
        $this->distanceTraveled = $distanceTraveled;
    }

    public function canMove($distance) : bool{
        return round($this->fuelCostPerKm * $distance, 2) <= round($this->fuelAmount, 2);
    }

    public function __toString()
    {
        $fuel = number_format(abs($this->fuelAmount), 2, '.', '');
        return "$this->model $fuel $this->distanceTraveled";
    }
}

$n = intval(readline());
$cars = [];

for ($i = 0; $i < $n; $i++){
    $input = explode(' ', readline());
    $model = $input[0];
    $fuelAmount = floatval($input[1]);
    $fuelCostPerKm = floatval($input[2]);

    $cars[$model] = new Car($model, $fuelAmount, $fuelCostPerKm);
}

$input = explode(' ', readline());

while ($input[0] !== 'End') {
    $model = $input[1];
    $distance = floatval($input[2]);

    if ($cars[$model]->canMove($distance)) {
        $fuelNeeded = $distance * $cars[$model]->getFuelCostPerKm();
        $cars[$model]->setFuelAmount($cars[$model]->getFuelAmount() - $fuelNeeded);
        $cars[$model]->setDistanceTraveled($cars[$model]->getDistanceTraveled() + $distance);
    } else {
        echo "Insufficient fuel for the drive" . PHP_EOL;
    }
    $input = explode(' ', readline());
}

foreach ($cars as $car) {
    echo $car . PHP_EOL;
}