<?php

class Cymric extends Cat
{
    /**
     * @var int
     */
    private $furLength;


    public function __construct(string $name, int $furLength)
    {
        parent::__construct($name);
        $this->setEarSize($furLength);
    }


    /**
     * @param int $earSize
     */
    public function setEarSize(int $furLength): void
    {
        $this->furLength = $furLength;
    }

    public function __toString()
    {
        return parent::__toString() . $this->furLength . PHP_EOL;
    }
}