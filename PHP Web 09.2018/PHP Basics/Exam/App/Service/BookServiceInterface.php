<?php

namespace App\Service;


use App\DTO\BookDTO;

interface BookServiceInterface
{
    /**
     * @return \Generator|BookDTO[]
     */
    public function getAll(): \Generator;

    public function getOneById(int $id): ?BookDTO;

    /**
     * @param int $userId
     * @return \Generator|BookDTO[]
     */
    public function getAllByUserId(int $userId): \Generator;

    public function add(BookDTO $bookDTO): bool;

    public function edit(BookDTO $bookDTO, int $id): bool;

    public function delete(int $id): bool;
}