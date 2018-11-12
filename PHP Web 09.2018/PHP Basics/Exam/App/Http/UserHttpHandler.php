<?php

namespace App\Http;

use App\DTO\UserDTO;
use App\Service\UserServiceInterface;

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

    public function profile(UserServiceInterface $userService)
    {
        $user = $userService->getCurrentUser();
        $this->render('users/profile', $user);
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
            $this->redirect('profile.php');
        } catch (\Exception $e) {
            $user = $this->dataBinder->bind($formData, UserDTO::class);
            $this->render('users/login', $user, [$e->getMessage()]);
        }
    }
}