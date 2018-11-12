<?php

namespace App\Service;


use App\DTO\UserDTO;

interface UserServiceInterface
{
    public function getCurrentUser(): UserDTO;

    public function register(UserDTO $userDTO, string $confirmPassword): bool;

    public function login(string $username, string $password): ?UserDTO;
}