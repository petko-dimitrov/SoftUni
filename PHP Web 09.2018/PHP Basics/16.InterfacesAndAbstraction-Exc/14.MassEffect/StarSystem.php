<?php

class StarSystem
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var array
     */
    private $neighbours;

    /**
     * StarSystem constructor.
     * @param string $name
     */
    public function __construct(string $name)
    {
        $this->setName($name);
        $this->setNeighbours();
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
     * @return array
     */
    public function getNeighbours(): array
    {
        return $this->neighbours;
    }

    public function setNeighbours() {
        switch ($this->name) {
            case 'Artemis-Tau':
                $this->neighbours = ['Serpent-Nebula' => 50, 'Kepler-Verge' => 120];
                break;
            case 'Serpent-Nebula':
                $this->neighbours = ['Artemis-Tau' => 50, 'Hades-Gamma' => 360];
                break;
            case 'Hades-Gamma':
                $this->neighbours = ['Serpent-Nebula' => 360, 'Kepler-Verge' => 145];
                break;
            case 'Kepler-Verge':
                $this->neighbours = ['Hades-Gamma' => 145, 'Artemis-Tau' => 120];
                break;
            default:
                break;
        }
    }
}