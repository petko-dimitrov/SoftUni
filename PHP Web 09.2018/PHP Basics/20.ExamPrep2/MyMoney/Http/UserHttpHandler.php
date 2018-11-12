<?php

namespace MyMoney\Http;


use MyMoney\DTO\UserDTO;
use MyMoney\Service\UserServiceInterface;

class UserHttpHandler extends HttpHandlerAbstract
{
    public function register(UserServiceInterface $userService, array $formData = [])
    {
        if (isset($_POST['register'])) {
            $this->handleRegisterProcess($userService, $formData);
        } else {
            $this->render('users/register');
        }
    }

    public function login(UserServiceInterface $userService, array $formData = [])
    {
        if (isset($_POST['login'])) {
            $this->handleLoginProcess($userService, $formData);
        } else {
            $this->render('users/login');
        }
    }

    private function handleRegisterProcess(UserServiceInterface $userService, array $formData = [])
    {
        try {
            /** @var UserDTO $user */
            $user = $this->dataBinder->bind($formData, UserDTO::class);
            $userService->register($user, $formData['confirm_password']);
            $this->redirect('login.php');
        } catch (\Exception $e) {
            $user = $this->dataBinder->bind($formData, UserDTO::class);
            $this->render('users/register', $user, [$e->getMessage()]);
        }

    }

    private function handleLoginProcess(UserServiceInterface $userService, array $formData = [])
    {
        try {
            $userService->login($formData['username'], $formData['password']);
            $this->redirect('operations.php');
        } catch (\Exception $e) {
            $user = $this->dataBinder->bind($formData, UserDTO::class);
            $this->render('users/login', $user, [$e->getMessage()]);
        }
    }
}