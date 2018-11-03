<?php

class Animal
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
    protected $gender;

    /**
     * Animal constructor.
     * @param string $name
     * @param int $age
     * @param string $gender
     * @throws Exception
     */
    public function __construct(string $name, int $age, string $gender)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setGender($gender);
    }


    /**
     * @param string $name
     * @throws Exception
     */
    protected function setName(string $name): void
    {
        if ($name == '' || $name == null) {
            throw new Exception('Invalid input!');
        }
        $this->name = $name;
    }

    /**
     * @param int $age
     * @throws Exception
     */
    protected function setAge(int $age): void
    {
        if ($age < 0) {
            throw new Exception('Invalid input!');
        }
        $this->age = $age;
    }

    /**
     * @param string $gender
     * @throws Exception
     */
    protected function setGender(string $gender): void
    {
        if ($gender == '' && $gender == null) {
            throw new Exception('Invalid input!');
        }
        $this->gender = $gender;
    }

    public function produceSound(): string {
        return "Not implemented!";
    }

    public function __toString() {
        $type = get_class($this);
        return "{$type} {$this->name} {$this->age} {$this->gender}" .PHP_EOL. $this->produceSound() . PHP_EOL;
    }
}