<?php

namespace MyMoney\Repository;


use Database\DatabaseInterface;
use MyMoney\DTO\ReasonDTO;

class ReasonRepository implements ReasonRepositoryInterface
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
     * @return \Generator|ReasonDTO[]
     */
    public function findAll(): \Generator
    {
        return $this->db->query('SELECT reason_id AS reasonId, name
                                FROM reasons
                                ORDER BY name')
            ->execute()
            ->fetchAll(ReasonDTO::class);
    }

    public function findOne($id): ReasonDTO
    {
        return $this->db->query('SELECT reason_id AS reasonId, name
                                FROM reasons
                                WHERE reason_id = ?')
            ->execute([$id])
            ->fetchAll(ReasonDTO::class)
            ->current();
    }
}