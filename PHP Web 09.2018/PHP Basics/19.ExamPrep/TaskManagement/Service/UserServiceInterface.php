<?php

namespace TaskManagement\Service;


use TaskManagement\DTO\UserDTO;

interface UserServiceInterface
{
    public function getCurrentUser(): UserDTO;

    public function register(UserDTO $userDTO, string $confirmPassword): bool;

    public function login(string $username, string $password): ?UserDTO;
}