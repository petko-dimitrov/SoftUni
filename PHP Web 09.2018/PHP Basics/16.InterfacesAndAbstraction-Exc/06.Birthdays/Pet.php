<?php

class Pet implements IName, IBirthday
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $birthday;

    /**
     * Pet constructor.
     * @param string $name
     * @param string $birthday
     */
    public function __construct(string $name, string $birthday)
    {
        $this->setName($name);
        $this->setBirthday($birthday);
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
}