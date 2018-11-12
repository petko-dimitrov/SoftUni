<?php

namespace App\DTO;


class UserDTO
{
    private $userId;

    private $username;

    private $password;

    private $fullName;

    private $bornOn;


    public function getUserId()
    {
        return $this->userId;
    }


    public function setUserId($userId): void
    {
        $this->userId = $userId;
    }


    public function getUsername()
    {
        return $this->username;
    }


    /**
     * @param $username
     */
    public function setUsername($username): void
    {
        $this->username = $username;
    }

    public function getPassword()
    {
        return $this->password;
    }

    /**
     * @param $password
     */
    public function setPassword($password): void
    {
        $this->password = $password;
    }

    public function getFullName()
    {
        return $this->fullName;
    }

    /**
     * @param $fullName
     * @throws \Exception
     */
    public function setFullName($fullName): void
    {
        $this->fullName = $fullName;
    }

    public function getBornOn()
    {
        return $this->bornOn;
    }

    public function setBornOn($bornOn): void
    {
        $this->bornOn = $bornOn;
    }

}