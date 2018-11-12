<?php

namespace TaskManagement\Repository;


use TaskManagement\DTO\TaskDTO;

interface TaskRepositoryInterface
{
    /**
     * @return \Generator|TaskDTO[]
     */
    public function findAll(): \Generator;

    public function findOneById(int $id): ?TaskDTO;

    public function insert(TaskDTO $taskDTO): bool;

    public function update(TaskDTO $taskDTO, int $id): bool;

    public function delete(int $id): bool;
}