<?php

interface ISpy
{
    /**
     * @return string
     */
    public function getCodeNumber(): string;
    public function setCodeNumber(string $codeNumber): void;
}