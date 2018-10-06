<?php
class Person {
    /**
     * @var string
     */
    private $name;
    /**
     * @var int
     */
    private $age;

    /**
     * Person constructor.
     * @param string $name
     * @param int $age
     */
    public function __construct(string $name, int $age)
    {
        $this->setName($name);
        $this->setAge($age);
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
    private function setName(string $name): void
    {
        $this->name = $name;
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
    private function setAge(int $age): void
    {
        $this->age = $age;
    }


}

class Family {
    /**
     * @var array
     */
    private $people;

    /**
     * Family constructor.
     * @param array $people
     */
    public function __construct()
    {
        $this->people = [];
    }

    public function addMember(Person $person): void {
        $this->people[] = $person;
    }

    public function getOldestMember(): Person {
        usort($this->people, function (Person $a, Person $b) {
            return $b->getAge() <=> $a->getAge();
        });
        return $this->people[0];
    }
}

$n = intval(readline());
$family = new Family();

for ($i = 0; $i < $n; $i++){
    list($name, $age) = explode(' ', readline());
    $person = new Person($name, intval($age));
    $family->addMember($person);
}

$oldestPerson = $family->getOldestMember();
echo $oldestPerson->getName() . ' ' . $oldestPerson->getAge();