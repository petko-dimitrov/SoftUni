<?php

namespace App\Repository;


use App\DTO\GenreDTO;
use Database\DatabaseInterface;

class GenreRepository implements GenreRepositoryInterface
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
     * @return \Generator|GenreDTO[]
     */
    public function findAll(): \Generator
    {
        return $this->db->query('SELECT genre_id AS genreId, name
                                FROM genres')
            ->execute()
            ->fetchAll(GenreDTO::class);
    }

    public function findOne($id): GenreDTO
    {
        return $this->db->query('SELECT genre_id AS genreId, name
                                FROM genres
                                WHERE genre_id = ?')
            ->execute([$id])
            ->fetchAll(GenreDTO::class)
            ->current();
    }
}