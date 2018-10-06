<?php
class Car {
    private $model;
    private $engine;
    private $weight;
    private $color;

    /**
     * Car constructor.
     * @param $model
     * @param $engine
     * @param $weight
     * @param $color
     */
    public function __construct(string $model, Engine $engine, string $weight = 'n/a', string $color = 'n/a')
    {
        $this->model = $model;
        $this->engine = $engine;
        $this->weight = $weight;
        $this->color = $color;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @return Engine
     */
    public function getEngine(): Engine
    {
        return $this->engine;
    }

    /**
     * @return string
     */
    public function getWeight(): string
    {
        return $this->weight;
    }

    /**
     * @return string
     */
    public function getColor(): string
    {
        return $this->color;
    }

    public function __toString()
    {
        $eng = $this->getEngine();
        $model = $eng->getModel();
        $power = $eng->getPower();
        $displacement = $eng->getDisplacement();
        $efficiency = $eng->getEfficiency();
        $result = "$this->model:" .PHP_EOL;
        $result .= " $model:" . PHP_EOL;
        $result .= "  Power: $power" . PHP_EOL;
        $result .= "  Displacement: $displacement" . PHP_EOL;
        $result .= "  Efficiency: $efficiency" . PHP_EOL;
        $result .= " Weight: $this->weight" . PHP_EOL;
        $result .= " Color: $this->color";
        return $result;
    }
}

class Engine {
    private $model;
    private $power;
    private $displacement;
    private $efficiency;

    /**
     * Engine constructor.
     * @param $model
     * @param $power
     * @param $displacement
     * @param $efficiency
     */
    public function __construct(string $model, string $power, string $displacement = 'n/a', string $efficiency = 'n/a')
    {
        $this->model = $model;
        $this->power = $power;
        $this->displacement = $displacement;
        $this->efficiency = $efficiency;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @return string
     */
    public function getPower(): string
    {
        return $this->power;
    }

    /**
     * @return string
     */
    public function getDisplacement(): string
    {
        return $this->displacement;
    }

    /**
     * @return string
     */
    public function getEfficiency(): string
    {
        return $this->efficiency;
    }
}

$n = intval(readline());
$engines = [];

for ($i = 0; $i < $n; $i++){
    $input = explode(' ', readline());
    if (count($input) === 2) {
        list($model, $power) = $input;
        $engines[$model] = new Engine($model, $power);
    } else if(count($input) === 3) {
        if (ctype_digit($input[2])) {
            list($model, $power, $displacement) = $input;
            $engines[$model] = new Engine($model, $power, $displacement);
        } else {
            list($model, $power, $efficiency) = $input;
            $engines[$model] = new Engine($model, $power, 'n/a', $efficiency);
        }
    } else {
        list($model, $power, $displacement, $efficiency) = $input;
        $engines[$model] = new Engine($model, $power, $displacement, $efficiency);
    }
}

$m = intval(readline());
$cars = [];

for ($i = 0; $i < $m; $i++){
    $input = explode(' ', readline());
    $engine = $engines[$input[1]];

    if (count($input) === 2) {
        list($model, $eng) = $input;
        $cars[] = new Car($model, $engine);
    } else if(count($input) === 3) {
        if (ctype_digit($input[2])) {
            list($model, $eng, $weight) = $input;
            $cars[] = new Car($model, $engine, $weight);
        } else {
            list($model, $eng, $color) = $input;
            $cars[] = new Car($model, $engine, 'n/a', $color);
        }
    } else {
        list($model, $eng, $weight, $color) = $input;
        $cars[] = new Car($model, $engine, $weight, $color);
    }
}

foreach ($cars as $car) {
    echo $car . PHP_EOL;
}