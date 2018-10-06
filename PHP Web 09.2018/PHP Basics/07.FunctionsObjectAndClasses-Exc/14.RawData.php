<?php
class Car {
    private $model;
    private $engine;
    private $cargo;
    private $tires;

    /**
     * Car constructor.
     * @param $model
     * @param $engine
     * @param $cargo
     * @param $tires
     */
    public function __construct(string $model, Engine $engine, Cargo $cargo, array $tires)
    {
        $this->model = $model;
        $this->engine = $engine;
        $this->cargo = $cargo;
        $this->tires = $tires;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @param string $model
     */
    public function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * @return Engine
     */
    public function getEngine(): Engine
    {
        return $this->engine;
    }

    /**
     * @param Engine $engine
     */
    public function setEngine(Engine $engine): void
    {
        $this->engine = $engine;
    }

    /**
     * @return Cargo
     */
    public function getCargo(): Cargo
    {
        return $this->cargo;
    }

    /**
     * @param Cargo $cargo
     */
    public function setCargo(Cargo $cargo): void
    {
        $this->cargo = $cargo;
    }

    /**
     * @return array
     */
    public function getTires(): array
    {
        return $this->tires;
    }

    /**
     * @param array $tires
     */
    public function setTires(array $tires): void
    {
        $this->tires = $tires;
    }


}

class Engine {
    private $speed;
    private $power;

    /**
     * Engine constructor.
     * @param $speed
     * @param $power
     */
    public function __construct(int $speed, int $power)
    {
        $this->speed = $speed;
        $this->power = $power;
    }

    /**
     * @return int
     */
    public function getSpeed(): int
    {
        return $this->speed;
    }

    /**
     * @param int $speed
     */
    public function setSpeed(int $speed): void
    {
        $this->speed = $speed;
    }

    /**
     * @return int
     */
    public function getPower(): int
    {
        return $this->power;
    }

    /**
     * @param int $power
     */
    public function setPower(int $power): void
    {
        $this->power = $power;
    }
}

class Cargo {
    private $weight;
    private $type;

    /**
     * Cargo constructor.
     * @param $weight
     * @param $type
     */
    public function __construct(int $weight, string $type)
    {
        $this->weight = $weight;
        $this->type = $type;
    }

    /**
     * @return int
     */
    public function getWeight(): int
    {
        return $this->weight;
    }

    /**
     * @param int $weight
     */
    public function setWeight(int $weight): void
    {
        $this->weight = $weight;
    }

    /**
     * @return string
     */
    public function getType(): string
    {
        return $this->type;
    }

    /**
     * @param string $type
     */
    public function setType(string $type): void
    {
        $this->type = $type;
    }
}

class Tire {
    private $pressure;
    private $age;

    /**
     * Tire constructor.
     * @param $pressure
     * @param $age
     */
    public function __construct(float $pressure, int $age)
    {
        $this->pressure = $pressure;
        $this->age = $age;
    }

    /**
     * @return float
     */
    public function getPressure(): float
    {
        return $this->pressure;
    }

    /**
     * @param float $pressure
     */
    public function setPressure(float $pressure): void
    {
        $this->pressure = $pressure;
    }

    /**
     * @return int
     */
    public function getAge(): int
    {
        return $this->age;
    }

    /**
     * @param int $age
     */
    public function setAge(int $age): void
    {
        $this->age = $age;
    }
}

$n = intval(readline());
$cars = [];

for ($i = 0; $i < $n; $i++){
    $input = explode(' ', readline());
    $model = $input[0];
    $engine = new Engine(intval($input[1]), intval($input[2]));
    $cargo = new Cargo(intval($input[3]), $input[4]);
    $tires = [];

    for ($j = 5; $j < count($input); $j+=2){
        $tires[] = new Tire(floatval($input[$j]), intval($input[$j+1]));
    }

    $cars[] = new Car($model, $engine, $cargo, $tires);
}

$command = readline();

if ($command === 'fragile') {
    $fragileCars = array_filter($cars, function (Car $car){
        $tires = $car->getTires();
        $isFlat = false;
        foreach ($tires as $tire) {
            if ($tire->getPressure() < 1) {
                $isFlat = true;
                break;
            }
        }
        return $car->getCargo()->getType() == 'fragile' && $isFlat;
    });

    foreach ($fragileCars as $fragileCar) {
        echo $fragileCar->getModel() . PHP_EOL;
    }
} else {
    $flamableCars = array_filter($cars, function (Car $car) {
        return $car->getCargo()->getType() == 'flamable' && $car->getEngine()->getPower() > 250;
    });

    foreach ($flamableCars as $flamableCar) {
        echo $flamableCar->getModel() . PHP_EOL;
    }
}