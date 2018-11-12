<?php

namespace MyMoney\Service;


use MyMoney\DTO\OperationDTO;

interface OperationServiceInterface
{
    /**
     * @return \Generator|OperationDTO[]
     */
    public function getAll(): \Generator;

    public function findOneById(int $id): ?OperationDTO;

    public function statistics(): \Generator;

    public function add(OperationDTO $operationDTO): bool;

    public function edit(OperationDTO $operationDTO, int $id): bool;

    public function delete(int $id): bool;
}