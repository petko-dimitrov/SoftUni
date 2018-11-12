<?php

namespace TaskManagement\Service;


use TaskManagement\DTO\CategoryDTO;

interface CategoryServiceInterface
{
    /**
     * @return \Generator|CategoryDTO[]
     */
    public function getAll(): \Generator;

    public function getOne(int $id): CategoryDTO;
}