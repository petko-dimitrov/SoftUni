<?php

class Vehicle
{
    /**
     * @var int
     */
    private $numberDoors;

    /**
     * @var string
     */
    protected $color;

    /**
     * Vehicle constructor.
     * @param int $numberDoors
     * @param string $color
     */
    public function __construct(int $numberDoors, string $color)
    {
        $this->setDoors($numberDoors);
        $this->setColor($color);
    }

    /**
     * @return int
     */
    public function getDoors(): int
    {
        return $this->numberDoors;
    }

    /**
     * @param int $numberDoors
     */
    protected function setDoors(int $numberDoors): void
    {
        $this->numberDoors = $numberDoors;
    }

    /**
     * @return string
     */
    public function getColor(): string
    {
        return $this->color;
    }

    /**
     * @param string $color
     */
    public function setColor(string $color): void
    {
        $this->color = $color;
    }

    public function __get($name){
        if ($this->{$name}) {
            return $this->{$name};
        }

        throw new Exception('property doesn’t exist');
    }

    public function paint ($color) {
        $this->setColor($color);
    }
}