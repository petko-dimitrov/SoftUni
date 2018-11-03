<?php

class Dreadnought extends Ship
{
    public function __construct(string $name, StarSystem $starSystem)
    {
        parent::__construct($name, $starSystem);
        $this->setHealth(200);
        $this->setShields(300);
        $this->setDamage(150);
        $this->setFuel(700);
        $this->setProjectile('Laser');
    }

    public function increaseShields(): void {
        $this->setShields($this->getShields() + 50);
    }

    public function decreaseShields(): void {
        $this->setShields($this->getShields() - 50);

        if ($this->getShields() < 0) {
            $this->setShields(0);
        }
    }
}