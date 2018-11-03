<?php

namespace App\Repository;


use App\Data\UserDTO;
use Database\DatabaseInterface;

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
          $this->db->query('INSERT INTO users (username, password, first_name, last_name, born_on)
                        VALUE (?, ?, ?, ?, ?)')
            ->execute([
                $userDTO->getUsername(),
                $userDTO->getPassword(),
                $userDTO->getFirstName(),
                $userDTO->getLastName(),
                $userDTO->getBornOn()
            ]);

          return true;
    }


    public function findOneByUsername(string $username): ?UserDTO
    {
        return $this->db->query('SELECT id, username, password, first_name AS firstName,
                                last_name AS lastName, born_on AS bornOn
                                FROM users
                                WHERE username = ?')
            ->execute([
                $username
            ])->fetchAll(UserDTO::class)->current();
    }

    public function findOneById(int $id): ?UserDTO
    {
        return $this->db->query('SELECT id, username, password, first_name AS firstName,
                                last_name AS lastName, born_on AS bornOn
                                FROM users
                                WHERE id = ?')
            ->execute([$id])
            ->fetchAll(UserDTO::class)->current();
    }

    public function edit(int $id, UserDTO $userDTO): bool
    {
        $this->db->query('UPDATE users 
                                SET username = ?, password = ?, first_name = ?, last_name = ?, born_on = ?
                                WHERE id = ?')
            ->execute([
                $userDTO->getUsername(),
                $userDTO->getPassword(),
                $userDTO->getFirstName(),
                $userDTO->getLastName(),
                $userDTO->getBornOn(),
                $id
            ]);

        return true;
    }

    /**
     * @return \Generator|UserDTO[]
     */
    public function findAll(): \Generator
    {
        return $this->db->query('SELECT id, username, password, first_name AS firstName,
                                last_name AS lastName, born_on AS bornOn
                                FROM users')
            ->execute()->fetchAll(UserDTO::class);
    }
}