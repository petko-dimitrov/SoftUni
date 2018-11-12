<?php

namespace TaskManagement\Repository;


use Database\DatabaseInterface;
use TaskManagement\DTO\CategoryDTO;

class CategoryRepository implements CategoryRepositoryInterface
{
    /**
     * @var DatabaseInterface
     */
    private $db;

    /**
     * UserRepository constructor.
     * @param DatabaseInterface $db
     */
    public function __construct(DatabaseInterface $db)
    {
        $this->db = $db;
    }

    /**
     * @return \Generator|CategoryDTO[]
     */
    public function findAll(): \Generator
    {
        return $this->db->query('SELECT category_id AS categoryId, name
                                FROM categories
                                ORDER BY name')
            ->execute()
            ->fetchAll(CategoryDTO::class);
    }

    public function findOne($id): CategoryDTO
    {
        return $this->db->query('SELECT category_id AS categoryId, name
                                FROM categories
                                WHERE category_id = ?')
            ->execute([$id])
            ->fetchAll(CategoryDTO::class)
            ->current();
    }
}