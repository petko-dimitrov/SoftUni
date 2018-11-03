<?php

class Citizen extends Creature
{
    /**
     * @var int
     */
    private $age;

    public function __construct(string $name, int $age, string $id)
    {
        $this->setAge($age);
        parent::__construct($name, $id);
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