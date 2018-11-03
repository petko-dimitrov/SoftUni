<?php
spl_autoload_register();

class Car extends Vehicle
{
    /**
     * @var string
     */
    private $brand;
    /**
     * @var string
     */
    private $model;
    /**
     * @var int
     */
    private $year;

    public function __construct(int $numberDoors, string $color, string $brand, string $model, int $year)
    {
        parent::__construct($numberDoors, $color);
        $this->brand = $brand;
        $this->model = $model;
        $this->year = $year;
    }

    public function paint($paint_color) {
        return $this->color = $paint_color;
    }
}