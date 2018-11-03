<?php

class Frigate extends Ship
{
    /**
     * @var int
     */
    private $projectilesFired;

    public function __construct(string $name, StarSystem $starSystem)
    {
        parent::__construct($name, $starSystem);
        $this->setHealth(60);
        $this->setShields(50);
        $this->setDamage(30);
        $this->setFuel(220);
        $this->setProjectile('ShieldReaver');
        $this->projectilesFired = 0;
    }

    /**
     * @return int
     */
    public function getProjectilesFired(): int
    {
        return $this->projectilesFired;
    }

    /**
     * @param int $projectilesFired
     */
    public function setProjectilesFired(): void
    {
        $this->projectilesFired++;
    }

    public function __toString()
    {
        return parent::__toString() . PHP_EOL . "-Projectiles fired: {$this->projectilesFired}";
    }
}