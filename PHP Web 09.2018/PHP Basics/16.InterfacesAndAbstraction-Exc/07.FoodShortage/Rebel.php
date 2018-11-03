<?php

class Rebel implements IName, Buyer
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
    private $group;
    /**
     * @var int
     */
    private $food;

    /**
     * Rebel constructor.
     * @param string $name
     * @param int $age
     * @param string $group
     */
    public function __construct(string $name, int $age, string $group)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setGroup($group);
        $this->food = 0;
    }

    /**
     * @param int $age
     */
    public function setAge(int $age): void
    {
        $this->age = $age;
    }

    /**
     * @param string $group
     */
    public function setGroup(string $group): void
    {
        $this->group = $group;
    }


    public function setName($name): void
    {
        $this->name = $name;
    }

    /**
     * @return int
     */
    public function getFood(): int
    {
        return $this->food;
    }

    public function buyFood()
    {
        $this->food += 5;
    }
}