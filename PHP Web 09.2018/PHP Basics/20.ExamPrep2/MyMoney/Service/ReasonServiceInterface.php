<?php

namespace MyMoney\Service;


use MyMoney\DTO\ReasonDTO;

interface ReasonServiceInterface
{
    /**
     * @return \Generator|ReasonDTO[]
     */
    public function getAll(): \Generator;

    public function getOne(int $id): ReasonDTO;
}