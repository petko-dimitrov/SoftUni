<?php

class Person
{
    /**
     * @var string
     */
    private $firstName;
    /**
     * @var string
     */
    private $lastName;
    /**
     * @var string
     */
    private $birthday;
    /**
     * @var Person[]
     */
    private $parents;
    /**
     * @var Person[]
     */
    private $children;

    public function __construct(string $firstName, string $lastName, string $birthday)
    {
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setBirthday($birthday);
        $this->parents = [];
        $this->children = [];
    }

    /**
     * @return string
     */
    public function getFirstName(): string
    {
        return $this->firstName;
    }

    /**
     * @return string
     */
    public function getLastName(): string
    {
        return $this->lastName;
    }

    /**
     * @return string
     */
    public function getBirthday(): string
    {
        return $this->birthday;
    }


    /**
     * @param string $firstName
     */
    private function setFirstName(string $firstName): void
    {
        $this->firstName = $firstName;
    }

    /**
     * @param string $lastName
     */
    private function setLastName(string $lastName): void
    {
        $this->lastName = $lastName;
    }

    /**
     * @param string $birthday
     */
    private function setBirthday(string $birthday): void
    {
        $this->birthday = $birthday;
    }

    public function addParent(Person $parent) {
        $this->parents[] = $parent;
    }

    public function addChild(Person $child) {
        $this->children[] = $child;
    }

    public function searchConnection (array $people, string $type, string $param) {
        foreach ($people as $man) {
            $manName = $man->getFirstName() . ' ' . $man->getLastName();

            if ($manName == $param || $man->getBirthday() == $param) {
                if ($type == 'parent') {
                    $this->addParent($man);
                } else {
                    $this->addChild($man);
                }
                return;
            }
        }
    }

    public function __toString()
    {
        $result = "{$this->firstName} {$this->lastName} {$this->birthday}" . PHP_EOL;
        $result .= "Parents:" . PHP_EOL;
        foreach ($this->parents as $parent) {
            $result .= "{$parent->getFirstName()} {$parent->getLastName()} {$parent->getBirthday()}" . PHP_EOL;
        }
        $result .= "Children:" . PHP_EOL;
        foreach ($this->children as $child) {
            $result .= "{$child->getFirstName()} {$child->getLastName()} {$child->getBirthday()}" . PHP_EOL;
        }
        return $result;
    }
}