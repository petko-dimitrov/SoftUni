<?php

abstract class Hero
{
    /**
     * @var string
     */
    protected $username;

    /**
     * @var int
     */
    protected $level;
    /**
     * @var string
     */
    protected $hashedPassword;

    /**
     * Hero constructor.
     * @param string $username
     * @param int $level
     */
    public function __construct(string $username, int $level)
    {
        $this->setUsername($username);
        $this->setLevel($level);
    }

    /**
     * @param string $username
     */
    private function setUsername(string $username): void
    {
        $this->username = $username;
    }


    /**
     * @param int $level
     */
    private function setLevel(int $level): void
    {
        $this->level = $level;
    }
}