<?php

abstract class Cat
{
    /**
     * @var string
     */
    private $name;

    /**
     * Cat constructor.
     * @param string $name
     */
    public function __construct(string $name)
    {
        $this->setName($name);
    }


    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    public function __toString()
    {
        $breed = get_class($this);
        return "{$breed} {$this->name} ";
    }
}