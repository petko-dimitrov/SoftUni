<?php

class Mission
{
    /**
     * @var string
     */
    private $codeName;
    /**
     * @var string
     */
    private $state;

    /**
     * Mission constructor.
     * @param string $codeName
     * @param string $state
     * @throws \Exception
     */
    public function __construct(string $codeName, string $state)
    {
        $this->setCodeName($codeName);
        $this->setState($state);
    }

    /**
     * @return string
     */
    public function getCodeName(): string
    {
        return $this->codeName;
    }

    /**
     * @param string $codeName
     */
    private function setCodeName(string $codeName): void
    {
        $this->codeName = $codeName;
    }

    /**
     * @return string
     */
    public function getState(): string
    {
        return $this->state;
    }

    /**
     * @param string $state
     * @throws \Exception
     */
    private function setState(string $state): void
    {
        if (strtolower($state) != 'inprogress' && strtolower($state) != 'finished') {
            throw new \Exception('Invalid mission!');
        }
        $this->state = $state;
    }

    public function completeMission(): void {
        $this->state = 'Finished';
    }
}