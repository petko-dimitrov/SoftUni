<?php

class Robot extends Creature
{
    public function __construct(string $name, string $id)
    {
        parent::__construct($name, $id);
    }
}