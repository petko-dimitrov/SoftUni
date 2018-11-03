<?php

class LeutenantGeneral extends PrivateSoldier implements ILeutenantGeneral
{
    /**
     * @var PrivateSoldier[]
     */
    private $privates;

    public function __construct(string $id, string $firstName, string $lastName, float $salary)
    {
        parent::__construct($id, $firstName, $lastName, $salary);
        $this->privates = [];
    }

    public function addPrivate(PrivateSoldier $privateSoldier): void {
        $this->privates[] = $privateSoldier;
    }

    public function __toString()
    {
        $result = parent::__toString() . PHP_EOL . "Privates:";
        foreach ($this->privates as $private) {
            $privateStr = PHP_EOL . "  {$private->__toString()}";
            $result .= $privateStr;
        }
        return $result;
    }
}