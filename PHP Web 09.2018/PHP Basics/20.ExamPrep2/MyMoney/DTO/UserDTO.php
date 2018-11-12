<?php

namespace MyMoney\DTO;


class UserDTO
{
    const USERNAME_MIN_LENGTH = 4;
    const PASSWORD_MIN_LENGTH = 4;
    const NAME_MIN_LENGTH = 5;
    const FIELDS_MAX_LENGTH = 255;

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
     * @throws \Exception
     */
    public function setUsername($username): void
    {
        //DTOValidator::validate(self::USERNAME_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $username, 'Username');

        $this->username = $username;
    }

    public function getPassword()
    {
        return $this->password;
    }

    /**
     * @param $password
     * @throws \Exception
     */
    public function setPassword($password): void
    {
        //DTOValidator::validate(self::PASSWORD_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $password, 'Password');
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
        //DTOValidator::validate(self::NAME_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $fullName, 'Full name');

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