<?php

interface ISoldier
{
    public function getId(): string;
    public function setId(string $id): void;
    public function getFirstName(): string;
    public function setFirstName(string $firstName): void;
    public function getLastName(): string;
    public function setLastName(string $lastName): void;
}