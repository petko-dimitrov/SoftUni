<?php

namespace MyMoney\Repository;


use MyMoney\DTO\ReasonDTO;

interface ReasonRepositoryInterface
{
    /**
     * @return \Generator|ReasonDTO[]
     */
    public function findAll(): \Generator;

    public function findOne($id): ReasonDTO;
}