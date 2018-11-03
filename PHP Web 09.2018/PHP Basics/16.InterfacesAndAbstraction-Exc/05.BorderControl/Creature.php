<?php

abstract class Creature
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $id;

    /**
     * Creature constructor.
     * @param string $name
     * @param string $id
     */
    public function __construct(string $name, string $id)
    {
        $this->setName($name);
        $this->setId($id);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    protected function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * @param string $id
     */
    protected function setId(string $id): void
    {
        $this->id = $id;
    }

    public function identify($idEnd) {
        $length = strlen($idEnd);
        if (substr($this->id, -$length, $length) == $idEnd) {
            return $this->id . PHP_EOL;
        }
    }
}