<?php

abstract class Ship
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var StarSystem
     */
    private $starSystem;
    /**
     * @var float
     */
    private $health;
    /**
     * @var float
     */
    private $shields;
    /**
     * @var float
     */
    private $damage;
    /**
     * @var float
     */
    private $fuel;
    /**
     * @var string[]
     */
    private $enhancements;
    /**
     * @var string
     */
    private $projectile;

    /**
     * Ship constructor.
     * @param string $name
     * @param StarSystem $starSystem
     */
    public function __construct(string $name, StarSystem $starSystem)
    {
        $this->setName($name);
        $this->setStarSystem($starSystem);
        $this->enhancements = [];
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return StarSystem
     */
    public function getStarSystem(): StarSystem
    {
        return $this->starSystem;
    }

    /**
     * @param StarSystem $starSystem
     */
    public function setStarSystem(StarSystem $starSystem): void
    {
        $this->starSystem = $starSystem;
    }

    /**
     * @return float
     */
    public function getHealth(): float
    {
        return $this->health;
    }

    /**
     * @param float $health
     */
    public function setHealth(float $health): void
    {
        $this->health = $health;
    }

    /**
     * @return float
     */
    public function getShields(): float
    {
        return $this->shields;
    }

    /**
     * @param float $shields
     */
    public function setShields(float $shields): void
    {
        $this->shields = $shields;
    }

    /**
     * @return float
     */
    public function getDamage(): float
    {
        return $this->damage;
    }

    /**
     * @param float $damage
     */
    public function setDamage(float $damage): void
    {
        $this->damage = $damage;
    }

    /**
     * @return float
     */
    public function getFuel(): float
    {
        return $this->fuel;
    }

    /**
     * @param float $fuel
     */
    public function setFuel(float $fuel): void
    {
        $this->fuel = $fuel;
    }

    /**
     * @return string[]
     */
    public function getEnhancements(): array
    {
        return $this->enhancements;
    }

    /**
     * @param string[] $enhancements
     */
    public function setEnhancements(array $enhancements): void
    {
        $this->enhancements = $enhancements;
    }

    /**
     * @return string
     */
    public function getProjectile(): string
    {
        return $this->projectile;
    }

    /**
     * @param string $projectile
     */
    public function setProjectile(string $projectile): void
    {
        $this->projectile = $projectile;
    }

    public function addEnhancement(string $enhancement) {
        $this->enhancements[] = $enhancement;
    }

    public function enhance($enhancement) {
        switch ($enhancement) {
            case 'ThanixCannon': $this->damage += 50; break;
            case 'KineticBarrier': $this->shields += 100; break;
            case 'ExtendedFuelCells': $this->fuel += 200; break;
            default: break;
        }
    }

    public function __toString()
    {
        $type = get_class($this);
        $fuel = number_format($this->fuel, 1, '.', '');

        if ($this->health < 0) {
            return "--{$this->name} - {$type}" . PHP_EOL ."(Destroyed)";
        }

        $result = "--{$this->name} - {$type}" . PHP_EOL;
        $result .= "-Location: {$this->starSystem->getName()}" . PHP_EOL;
        $result .= "-Health: {$this->health}" . PHP_EOL;
        $result .= "-Shields: {$this->shields}" . PHP_EOL;
        $result .= "-Damage: {$this->damage}" . PHP_EOL;
        $result .= "-Fuel: {$fuel}" . PHP_EOL;
        $result .= "-Enhancements: ";

        if (count($this->enhancements) > 0) {
            $result .= implode(', ', $this->enhancements);
        } else {
            $result .= "N/A";
        }

        return $result;
    }
}