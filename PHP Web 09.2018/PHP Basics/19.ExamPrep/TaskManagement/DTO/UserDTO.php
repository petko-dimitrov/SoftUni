<?php

namespace TaskManagement\DTO;


class UserDTO
{
    const USERNAME_MIN_LENGTH = 4;
    const PASSWORD_MIN_LENGTH = 6;
    const NAMES_MIN_LENGTH = 3;
    const FIELDS_MAX_LENGTH = 255;

    private $userId;

    private $username;

    private $password;

    private $firstName;

    private $lastName;


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
        DTOValidator::validate(self::USERNAME_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $username, 'Invalid username!');

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
        DTOValidator::validate(self::PASSWORD_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $password, 'Invalid password!');


        $this->password = $password;
    }

    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param $firstName
     * @throws \Exception
     */
    public function setFirstName($firstName): void
    {
        DTOValidator::validate(self::NAMES_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $firstName, 'Invalid first name!');

        $this->firstName = $firstName;
    }

    public function getLastName()
    {
        return $this->lastName;
    }

    /**
     * @param $lastName
     * @throws \Exception
     */
    public function setLastName($lastName): void
    {
        DTOValidator::validate(self::NAMES_MIN_LENGTH, self::FIELDS_MAX_LENGTH, $lastName, 'Invalid last name!');

        $this->lastName = $lastName;
    }


}