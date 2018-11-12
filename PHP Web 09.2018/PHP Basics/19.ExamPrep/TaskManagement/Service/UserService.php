<?php

namespace TaskManagement\Service;


use TaskManagement\DTO\UserDTO;
use TaskManagement\Repository\UserRepositoryInterface;

class UserService implements UserServiceInterface
{
    /**
     * @var UserRepositoryInterface
     */
    private $userRepository;

    /**
     * UserService constructor.
     * @param UserRepositoryInterface $userRepository
     */
    public function __construct(UserRepositoryInterface $userRepository)
    {
        $this->userRepository = $userRepository;
    }


    /**
     * @param UserDTO $userDTO
     * @param string $confirmPassword
     * @return bool
     * @throws \Exception
     */
    public function register(UserDTO $userDTO, string $confirmPassword): bool
    {
        if ($userDTO->getPassword() !== $confirmPassword) {
            throw new \Exception('Passwords mismatch!');
        }

        if ($this->userRepository->findOneByUsername($userDTO->getUsername()) != null) {
            throw new \Exception('User already exists!');
        }

        $passwordHash = password_hash($userDTO->getPassword(), PASSWORD_DEFAULT);
        $userDTO->setPassword($passwordHash);
        $this->userRepository->insert($userDTO);
        $user = $this->userRepository->findOneByUsername($userDTO->getUsername());
        $_SESSION['id'] = $user->getUserId();
        return true;
    }

    /**
     * @param string $username
     * @param string $password
     * @return null|UserDTO
     * @throws \Exception
     */
    public function login(string $username, string $password): ?UserDTO
    {
        $user = $this->userRepository->findOneByUsername($username);

        if ($user === null) {
            throw new \Exception('Invalid user!');
        }

        if (!password_verify($password, $user->getPassword())) {
            throw new \Exception('Invalid password!');
        }

        $_SESSION['id'] = $user->getUserId();

        return $user;
    }

    /**
     * @return UserDTO
     * @throws \Exception
     */
    public function getCurrentUser(): UserDTO
    {
        if (!isset($_SESSION['id'])) {
            throw new \Exception('No current user!');
        }

        return $this->userRepository->findOneById(intval($_SESSION['id']));
    }
}