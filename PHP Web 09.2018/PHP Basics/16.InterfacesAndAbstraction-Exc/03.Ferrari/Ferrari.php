<?php

class Ferrari implements IDrivable
{
    /**
     * @var string
     */
    private $model;
    /**
     * @var string
     */
    public $driver;

    /**
     * Ferrari constructor.
     * @param string $driver
     */
    public function __construct(string $driver)
    {
        $this->driver = $driver;
        $this->model = "488-Spider";
    }


    public function gas(): string
    {
         return "Zadu6avam sA!";
    }

    public function break(): string
    {
       return "Brakes!";
    }

    public function __toString()
    {
       return "{$this->model}/{$this->break()}/{$this->gas()}/{$this->driver}";
    }
}