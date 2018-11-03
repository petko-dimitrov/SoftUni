<?php
spl_autoload_register();

class Main
{
    /**
     * @var Ship[]
     */
    private $ships;

    /**
     * Main constructor.
     * @param Ship[] $ships
     */
    public function __construct()
    {
        $this->ships = [];
    }


    /**
     * @param string $shipType
     * @param string $shipName
     * @param string $starSystem
     * @param array|null $enhancements
     * @throws Exception
     */
    public function create(string $shipType, string $shipName, string $starSystem, array $enhancements = null): void
    {
        if (array_key_exists($shipName, $this->ships)) {
            throw new Exception('Ship with such name already exists');
        }

        $system = new StarSystem($starSystem);
        $ship = new $shipType($shipName, $system);

        if (isset($enhancements)) {
            foreach ($enhancements as $enhancement) {
                $ship->addEnhancement($enhancement);
                $ship->enhance($enhancement);
            }
        }

        $this->ships[$shipName] = $ship;
        echo "Created {$shipType} {$shipName}" . PHP_EOL;
    }

    /**
     * @param Ship $attackerShip
     * @param Ship $targetShip
     * @throws Exception
     */
    public function attack(string $attackerShip, string $targetShip): void {
        $attacker = $this->ships[$attackerShip];
        $target = $this->ships[$targetShip];

        if ($attacker->getHealth() <= 0 || $target->getHealth() <= 0) {
            throw new Exception('Ship is destroyed');
        }

        if ($attacker->getStarSystem() != $target->getStarSystem()) {
            throw new Exception('No such ship in star system');
        }

        if (method_exists($target, 'increaseShields')) {
            $target->increaseShields();
        }

        switch ($attacker->getProjectile()) {
            case 'PenetrationShell':
                $target->setHealth($target->getHealth() - $attacker->getDamage());
                break;
            case 'ShieldReaver':
                $target->setHealth($target->getHealth() - $attacker->getDamage());
                $target->setShields($target->getShields() - 2 * $attacker->getDamage());
                if ($target->getShields() < 0) {
                    $target->setShields(0);
                }
                break;
            case 'Laser':
                $damage = $attacker->getDamage() + 0.5 * $attacker->getShields();
                $target->setShields($target->getShields() - $damage);
                if ($target->getShields() < 0) {
                    $target->setHealth($target->getHealth() + $target->getShields());
                }
                break;
            default:
                break;
        }

        if (method_exists($target, 'decreaseShields')) {
            $target->decreaseShields();
        }

        echo "{$attackerShip} attacked {$targetShip}" . PHP_EOL;

        if ($target->getHealth() <= 0) {
            echo "{$targetShip} has been destroyed" . PHP_EOL;
        }

        if (get_class($attacker) == 'Frigate') {
            $attacker->setProjectilesFired();
        }
    }

    /**
     * @param string $shipName
     * @param string $starSystem
     * @throws Exception
     */
    public function plotJump(string $shipName, string $starSystem): void {
        $ship = $this->ships[$shipName];

        if ($ship->getStarSystem()->getName() == $starSystem) {
            throw new Exception("Ship is already in {$starSystem}");
        }

        $systemNeighbours = $ship->getStarSystem()->getNeighbours();

        if (!array_key_exists($starSystem, $systemNeighbours)) {
            throw new Exception("Cannot travel directly from {$ship->getStarSystem()->getName()} to {$starSystem}");
        }

        if ($ship->getFuel() - $systemNeighbours[$starSystem] < 0) {
            throw new Exception('Not enough fuel.');
        }


        $ship->setFuel($ship->getFuel() - $systemNeighbours[$starSystem]);
        echo "{$ship->getName()} jumped from {$ship->getStarSystem()->getName()} to {$starSystem}" . PHP_EOL;
        $ship->setStarSystem(new StarSystem($starSystem));
    }

    public function statusReport($shipName): void {
        $ship = $this->ships[$shipName];
        echo $ship . PHP_EOL;
    }

    public function systemReport ($starSystem): void {
        $intactShips = [];
        $destroyedShips = [];

        foreach ($this->ships as $ship) {
            if ($ship->getStarSystem()->getName() == $starSystem) {
                if ($ship->getHealth() > 0) {
                    $intactShips[] = $ship;
                } else {
                    $destroyedShips[] = $ship;
                }
            }
        }

        usort($intactShips, function (Ship $a, Ship $b) {
            if ($a->getHealth() == $b->getHealth()) {
                return $b->getShields() - $a->getShields();
            }
            return $b->getHealth() - $a->getHealth();
        });

        usort($destroyedShips, function (Ship $a, Ship $b) {
            return $a->getName() - $b->getName();
        });

        echo "Intact ships:" . PHP_EOL;

        if (count($intactShips) > 0) {
            foreach ($intactShips as $intactShip) {
                echo $intactShip . PHP_EOL;
            }
        } else {
            echo "N/A" . PHP_EOL;
        }

        echo "Destroyed ships:" . PHP_EOL;

        if (count($destroyedShips) > 0) {
            foreach ($destroyedShips as $destroyedShip) {
                echo $destroyedShip . PHP_EOL;
            }
        } else {
            echo "N/A" . PHP_EOL;
        }
    }
}

$command = explode(' ', readline());
$game = new Main();

while ($command[0] != 'over') {
    switch ($command[0]) {
        case 'create':
            $shipType = $command[1];
            $shipName = $command[2];
            $starSystem = $command[3];
            $enhancements = [];

            for ($i = 4; $i < count($command); $i++){
                $enhancements[] = $command[$i];
            }

            try {
                $game->create($shipType, $shipName, $starSystem, $enhancements);
            } catch (Exception $e) {
                echo $e->getMessage() . PHP_EOL;
            }
            break;
        case 'attack':
            $attacker = $command[1];
            $defender = $command[2];
            try {
                $game->attack($attacker, $defender);
            } catch (Exception $e) {
                echo $e->getMessage() . PHP_EOL;
            }
            break;
        case 'plot-jump':
            $shipName = $command[1];
            $starSystem = $command[2];
            try {
                $game->plotJump($shipName, $starSystem);
            } catch (Exception $e) {
                echo $e->getMessage() . PHP_EOL;
            }
            break;
        case 'status-report':
            $shipName = $command[1];
            $game->statusReport($shipName);
            break;
        case 'system-report':
            $starSystem = $command[1];
            $game->systemReport($starSystem);
            break;
        default:
            break;
    }

    $command = explode(' ', readline());
}