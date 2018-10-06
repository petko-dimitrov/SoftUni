<?php
class Person2 {
    /**
     * @var string
     */
    private $name;

    /**
     * Person2 constructor.
     * @param string $name
     */
    public function __construct(string $name)
    {
        $this->name = $name;
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
    public function setName(string $name): void
    {
        $this->name = $name;
    }



    public function sayHello() {
        echo "$this->name says \"Hello\"!";
    }
}

$name = readline();
$person = new Person2($name);
$person->sayHello();