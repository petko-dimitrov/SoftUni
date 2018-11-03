<?php

class StreetExtraordinaire extends Cat
{
    /**
     * @var int
     */
    private $decibelsOfMeows;

    public function __construct(string $name, int $decibelsOfMeows)
    {
        parent::__construct($name);
        $this->setDecibelsOfMeows($decibelsOfMeows);
    }

    /**
     * @param int $decibelsOfMeows
     */
    public function setDecibelsOfMeows(int $decibelsOfMeows): void
    {
        $this->decibelsOfMeows = $decibelsOfMeows;
    }

    public function __toString()
    {
        return parent::__toString() . $this->decibelsOfMeows . PHP_EOL;
    }
}