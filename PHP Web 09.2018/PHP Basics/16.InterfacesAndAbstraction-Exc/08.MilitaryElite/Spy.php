<?php

class Spy extends Soldier implements ISpy
{
    /**
     * @var string
     */
    private $codeNumber;

    public function __construct(string $id, string $firstName, string $lastName, string $codeNumber)
    {
        parent::__construct($id, $firstName, $lastName);
        $this->setCodeNumber($codeNumber);
    }

    /**
     * @return string
     */
    public function getCodeNumber(): string
    {
        return $this->codeNumber;
    }

    /**
     * @param string $codeNumber
     */
    public function setCodeNumber(string $codeNumber): void
    {
        $this->codeNumber = $codeNumber;
    }

    public function __toString()
    {
        return parent::__toString() . PHP_EOL . "Code Number: {$this->codeNumber}";
    }
}