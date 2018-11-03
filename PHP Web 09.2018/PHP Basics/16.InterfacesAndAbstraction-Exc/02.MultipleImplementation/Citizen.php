<?php

class Citizen implements Person, Identifiable, Birthable
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var int
     */
    private $age;
    /**
     * @var string
     */
    private $id;
    /**
     * @var string
     */
    private $birthday;

    /**
     * Citizen constructor.
     * @param string $name
     * @param int $age
     * @param string $id
     */
    public function __construct(string $name, int $age, string $id, string $date)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setId($id);
        $this->setBirthday($date);
    }

    public function setName(string $name): void
    {
        $this->name = $name;
    }

    public function setAge(int $age): void
    {
        $this->age = $age;
    }


    public function setId($id): void
    {
        $this->id = $id;
    }

    public function setBirthday($date): void
    {
        $this->birthday = $date;
    }

    public function __toString()
    {
        return $this->name . PHP_EOL . $this->age . PHP_EOL . $this->id . PHP_EOL . $this->birthday;
    }
}