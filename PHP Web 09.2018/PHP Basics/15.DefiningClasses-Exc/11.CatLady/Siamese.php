<?php

class Siamese extends Cat
{
    /**
     * @var int
     */
    private $earSize;

    /**
     * Siamese constructor.
     * @param string $name
     * @param int $earSize
     */
    public function __construct(string $name, int $earSize)
    {
        parent::__construct($name);
        $this->setEarSize($earSize);
    }


    /**
     * @param int $earSize
     */
    public function setEarSize(int $earSize): void
    {
        $this->earSize = $earSize;
    }

    public function __toString()
    {
        return parent::__toString() . $this->earSize . PHP_EOL;
    }
}