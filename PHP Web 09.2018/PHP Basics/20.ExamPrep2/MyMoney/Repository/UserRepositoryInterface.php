<?php

namespace MyMoney\Repository;


use MyMoney\DTO\UserDTO;

interface UserRepositoryInterface
{
    public function insert(UserDTO $userDTO): bool;

    public function findOneByUsername (string $username): ?UserDTO;

    public function findOneById (int $id): UserDTO;
}