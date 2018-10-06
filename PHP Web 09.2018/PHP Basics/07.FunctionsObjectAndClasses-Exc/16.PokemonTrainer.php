<?php
class Trainer {
    private $name;
    private $badges;
    private $pokemons;

    /**
     * Trainer constructor.
     * @param $name
     * @param $badges
     * @param $pokemons
     */
    public function __construct(string $name)
    {
        $this->name = $name;
        $this->badges = 0;
        $this->pokemons = [];
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
     * @return int
     */
    public function getBadges(): int
    {
        return $this->badges;
    }

    /**
     * @param int $badges
     */
    public function setBadges(int $badges): void
    {
        $this->badges = $badges;
    }

    /**
     * @return array
     */
    public function getPokemons(): array
    {
        return $this->pokemons;
    }

    /**
     * @param array $pokemons
     */
    public function setPokemons(array $pokemons): void
    {
        $this->pokemons = $pokemons;
    }

    public function addPokemon (Pokemon $pokemon) {
        array_push($this->pokemons, $pokemon);
    }

    public function __toString()
    {
        $numberOfPokemons = count($this->pokemons);
        return "$this->name $this->badges $numberOfPokemons";
    }
}

class Pokemon {
    private $name;
    private $element;
    private $health;

    /**
     * Pokemon constructor.
     * @param $name
     * @param $element
     * @param $health
     */
    public function __construct(string $name, string $element, float $health)
    {
        $this->name = $name;
        $this->element = $element;
        $this->health = $health;
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
     * @return string
     */
    public function getElement(): string
    {
        return $this->element;
    }

    /**
     * @param string $element
     */
    public function setElement(string $element): void
    {
        $this->element = $element;
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

}

$input = explode(' ', readline());
$trainers = [];

while ($input[0] !== 'Tournament') {
    list($name, $pokemonName, $pokemonElement, $pokemonHealth) = $input;

    if (!array_key_exists($name, $trainers)) {
        $trainers[$name] = new Trainer($name);
    }

    $pokemon = new Pokemon($pokemonName, $pokemonElement, floatval($pokemonHealth));
    $trainers[$name]->addPokemon($pokemon);
    $input = explode(' ', readline());
}

$input = readline();

while ($input !== 'End') {

    foreach ($trainers as $trainer) {
        $pokemons = $trainer->getPokemons();
        $hasPokemon = false;

        foreach ($pokemons as $pokemon) {
            if ($pokemon->getElement() == $input) {
                $hasPokemon = true;
                break;
            }
        }

        if ($hasPokemon) {
            $trainer->setBadges($trainer->getBadges() + 1);
        } else {
            $alivePokemons = [];

            foreach ($pokemons as $pokemon) {
                $pokemon->setHealth($pokemon->getHealth() - 10);

                if ($pokemon->getHealth() > 0) {
                    $alivePokemons[] = $pokemon;
                }
            }

            $trainer->setPokemons($alivePokemons);
        }
    }

    $input = readline();
}

usort($trainers, function (Trainer $a, Trainer $b) {
    return $b->getBadges() <=> $a->getBadges();
});

foreach ($trainers as $trainer) {
    echo $trainer . PHP_EOL;
}