<?php

class Cruiser extends Ship
{
    public function __construct(string $name, StarSystem $starSystem)
    {
        parent::__construct($name, $starSystem);
        $this->setHealth(100);
        $this->setShields(100);
        $this->setDamage(50);
        $this->setFuel(300);
        $this->setProjectile('PenetrationShell');
    }
}