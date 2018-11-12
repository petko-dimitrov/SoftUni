<?php

namespace App\Repository;


use App\DTO\BookDTO;

interface BookRepositoryInterface
{
    /**
     * @return \Generator|BookDTO[]
     */
    public function findAll(): \Generator;

    public function findOneById(int $id): ?BookDTO;

    /**
     * @param int $userId
     * @return \Generator|BookDTO[]
     */
    public function findAllByUserId(int $userId): \Generator;

    public function insert(BookDTO $bookDTO): bool;

    public function update(BookDTO $bookDTO, int $id): bool;

    public function delete(int $id): bool;
}