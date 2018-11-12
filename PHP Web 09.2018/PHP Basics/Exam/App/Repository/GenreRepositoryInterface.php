<?php

namespace App\Repository;


use App\DTO\GenreDTO;

interface GenreRepositoryInterface
{
    /**
     * @return \Generator|GenreDTO[]
     */
    public function findAll(): \Generator;

    public function findOne($id): GenreDTO;
}