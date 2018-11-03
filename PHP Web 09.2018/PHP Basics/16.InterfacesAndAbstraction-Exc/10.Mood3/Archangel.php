<?php

class Archangel extends Hero implements IHashable
{
    /**
     * @var int
     */
    private $mana;

    public function __construct(string $username, int $mana, int $level)
    {
        parent::__construct($username, $level);
        $this->setMana($mana);
        $this->hashPassword();
    }

    public function hashPassword(): void
    {
        $this->hashedPassword = strrev($this->username) . 21 * strlen($this->username);
    }

    private function setMana($mana)
    {
        $this->mana = $mana;
    }

    public function __toString()
    {
        $product = $this->mana * $this->level;
        return "\"{$this->username}\" | \"{$this->hashedPassword}\" -> Archangel" . PHP_EOL . $product;

    }
}