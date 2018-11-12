<?php

namespace MyMoney\Repository;


use MyMoney\DTO\OperationDTO;

interface OperationRepositoryInterface
{
    /**
     * @return \Generator|OperationDTO[]
     */
    public function findAll(): \Generator;

    public function findOneById(int $id): ?OperationDTO;

    public function insert(OperationDTO $operationDTO): bool;

    public function update(OperationDTO $operationDTO, int $id): bool;

    public function delete(int $id): bool;

    public function findStatistics (): \Generator;
}