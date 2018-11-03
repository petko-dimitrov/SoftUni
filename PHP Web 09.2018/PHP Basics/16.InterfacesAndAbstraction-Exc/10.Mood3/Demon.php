<?php


class Demon extends Hero implements IHashable
{
    /**
     * @var float
     */
    private $energy;


    public function __construct(string $username, float $energy, int $level)
    {
        parent::__construct($username, $level);
        $this->setEnergy($energy);
        $this->hashPassword();
    }

    public function hashPassword(): void
    {
        $this->hashedPassword = strlen($this->username) * 217;
    }

    private function setEnergy($energy)
    {
        $this->energy = $energy;
    }

    public function __toString()
    {
        $product = number_format($this->energy * $this->level, 1, '.', '');
        return "\"{$this->username}\" | \"{$this->hashedPassword}\" -> Demon" . PHP_EOL . $product;

    }
}