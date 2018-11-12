<?php

namespace TaskManagement\Repository;


use Database\DatabaseInterface;
use TaskManagement\DTO\UserDTO;

class UserRepository implements UserRepositoryInterface
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

    public function insert(UserDTO $userDTO): bool
    {
        $this->db->query('INSERT INTO users (username, password, first_name, last_name)
                        VALUES (?, ?, ?, ?)')
            ->execute([
                $userDTO->getUsername(),
                $userDTO->getPassword(),
                $userDTO->getFirstName(),
                $userDTO->getLastName(),
            ]);

        return true;
    }

    public function findOneByUsername(string $username): ?UserDTO
    {
        return $this->db->query('SELECT user_id AS userId, username, password, first_name AS firstName,
                                last_name AS lastName
                                FROM users
                                WHERE username = ?')
            ->execute([
                $username
            ])
            ->fetchAll(UserDTO::class)
            ->current();
    }

    public function findOneById(int $id): UserDTO
    {
        return $this->db->query('SELECT user_id AS userId, username, password, first_name AS firstName,
                                last_name AS lastName
                                FROM users
                                WHERE user_id = ?')
            ->execute([
                $id
            ])
            ->fetchAll(UserDTO::class)
            ->current();
    }
}