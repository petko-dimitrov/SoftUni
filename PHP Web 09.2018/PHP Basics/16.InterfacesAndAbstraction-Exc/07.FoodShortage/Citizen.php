<?php

class Citizen implements IName, IIdentity, IBirthday, Buyer
{
    /**
     * @var int
     */
    private $age;
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $birthday;
    /**
     * @var string
     */
    private $id;
    /**
     * @var int
     */
    private $food;

    public function __construct(string $name, int $age, string $id, string $birthday)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setId($id);
        $this->setBirthday($birthday);
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
     * @return string
     */
    public function getBirthday(): string
    {
        return $this->birthday;
    }


    public function setBirthday($date): void
    {
        $this->birthday = $date;
    }

    public function setId($id): void
    {
        $this->id = $id;
    }

    public function setName($name): void
    {
       $this->name = $name;
    }

    public function checkYear($searchYear): bool
    {
        $dateInfo = explode('/', $this->birthday);
        $year = intval($dateInfo[2]);
        if ($year == $searchYear) {
            return true;
        }
        return false;
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
        $this->food += 10;
    }
}