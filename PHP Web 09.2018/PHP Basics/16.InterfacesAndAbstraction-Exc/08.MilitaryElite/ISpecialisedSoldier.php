<?php

interface ISpecialisedSoldier
{
    /**
     * @return string
     */
    public function getCorps(): string;

    /**
     * @param string $corps
     */
    public function setCorps(string $corps): void;
}