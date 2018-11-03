<?php

class Commando extends SpecialisedSoldier implements ICommando
{
    /**
     * @var Mission[]
     */
    private $missions;

    public function __construct(string $id, string $firstName, string $lastName, float $salary, string $corps)
    {
        parent::__construct($id, $firstName, $lastName, $salary, $corps);
        $this->missions = [];
    }

    public function addMission(Mission $mission): void {
        $this->missions[] = $mission;
    }

    public function __toString()
    {
        $result = parent::__toString() . "Missions:";
        foreach ($this->missions as $mission) {
            $result .= PHP_EOL . "  Code Name: {$mission->getCodeName()} State: {$mission->getState()}";
        }
        return $result;
    }
}