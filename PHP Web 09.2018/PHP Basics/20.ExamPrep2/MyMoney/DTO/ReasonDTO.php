<?php

namespace MyMoney\DTO;


class ReasonDTO
{
    const NAME_MIN_LENGTH = 3;
    const NAME_MAX_LENGTH = 100;

    private $reasonId;

    private $name;

    public function getReasonId()
    {
        return $this->reasonId;
    }

    public function setReasonId($reasonId): void
    {
        $this->reasonId = $reasonId;
    }


    public function getName()
    {
        return $this->name;
    }

    /**
     * @param mixed $name
     * @throws \Exception
     */
    public function setName($name): void
    {
        DTOValidator::validate(self::NAME_MIN_LENGTH, self::NAME_MAX_LENGTH, $name, 'Name');

        $this->name = $name;
    }


}