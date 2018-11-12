<?php

namespace TaskManagement\Repository;


use TaskManagement\DTO\CategoryDTO;
use TaskManagement\DTO\UserDTO;

interface CategoryRepositoryInterface
{
    /**
     * @return \Generator|CategoryDTO[]
     */
    public function findAll(): \Generator;

    public function findOne($id): CategoryDTO;
}