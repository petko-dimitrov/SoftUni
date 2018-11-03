<?php

class Student extends Human
{
    /**
     * @var string
     */
    private $facultyNumber;

    public function __construct(string $firstName, string $lastName, string $facultyNumber)
    {
        parent::__construct($firstName, $lastName);
        $this->setFacultyNUmber($facultyNumber);
    }

    /**
     * @return int
     */
    public function getFacultyNumber(): string
    {
        return $this->facultyNumber;
    }

    /**
     * @param string $facultyNumber
     * @throws Exception
     */
    private function setFacultyNumber(string $facultyNumber): void
    {
        if (strlen($facultyNumber) < 5 || strlen($facultyNumber) > 10) {
            throw new Exception('Invalid faculty number!');
        }
        $this->facultyNumber = $facultyNumber;
    }

    public function __toString()
    {
        $names = parent::__toString();
        return $names . "Faculty number: {$this->facultyNumber}";
    }
}