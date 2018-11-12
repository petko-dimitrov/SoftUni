<?php

namespace App\Service;


use App\DTO\GenreDTO;

interface GenreServiceInterface
{
    /**
     * @return \Generator|GenreDTO[]
     */
    public function getAll(): \Generator;

    public function getOne(int $id): GenreDTO;
}