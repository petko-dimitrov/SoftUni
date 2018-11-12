<?php

namespace App\Service;


use App\DTO\UserDTO;
use App\Repository\UserRepositoryInterface;

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
        if (mb_strlen($userDTO->getUsername()) < 4 || mb_strlen($userDTO->getUsername()) > 255) {
            throw new \Exception('Username must be between 4 and 255 characters!');
        }

        if ($this->userRepository->findOneByUsername($userDTO->getUsername()) != null) {
            throw new \Exception('Username already taken!');
        }

        if (mb_strlen($userDTO->getPassword()) < 4 || mb_strlen($userDTO->getPassword()) > 255) {
            throw new \Exception('Password must be between 4 and 255 characters!');
        }

        if ($userDTO->getPassword() !== $confirmPassword) {
            throw new \Exception('Passwords mismatch!');
        }

        if (mb_strlen($userDTO->getFullName()) < 5 || mb_strlen($userDTO->getFullName()) > 255) {
            throw new \Exception('Full name must be between 5 and 255 characters!');
        }

        $passwordHash = password_hash($userDTO->getPassword(), PASSWORD_DEFAULT);
        $userDTO->setPassword($passwordHash);
        $this->userRepository->insert($userDTO);

        $_SESSION['success'] = $userDTO->getUsername();
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
        unset($_SESSION['success']);

        if (mb_strlen($username) < 4 || mb_strlen($username) > 255) {
            throw new \Exception('Username must be between 4 and 255 characters!');
        }

        $user = $this->userRepository->findOneByUsername($username);

        if ($user === null) {
            throw new \Exception("Your username does not exist. You might want to <a href='register.php'>register</a> first?");
        }

        if (mb_strlen($password) < 4 || mb_strlen($password) > 255) {
            throw new \Exception('Password must be between 4 and 255 characters!');
        }


        if (!password_verify($password, $user->getPassword())) {
            throw new \Exception('Wrong password. Did you forget it?');
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