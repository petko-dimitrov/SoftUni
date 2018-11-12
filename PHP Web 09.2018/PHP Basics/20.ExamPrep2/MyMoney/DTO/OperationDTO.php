<?php

namespace MyMoney\DTO;


class OperationDTO
{
    const SUM_MIN_VALUE = 0;
    const SUM_MAX_VALUE = 99999.99;

    const NOTES_MIN_LENGTH = 0;
    const NOTES_MAX_LENGTH = 255;

    private $operationId;

    private $type;

    /**
     * @var ReasonDTO
     */
    private $reason;

    private $sum;

    private $notes;

    private $onDate;

    private $forDate;

    /**
     * @var UserDTO
     */
    private $user;


    public function getOperationId()
    {
        return $this->operationId;
    }


    public function setOperationId($operationId): void
    {
        $this->operationId = $operationId;
    }


    public function getType()
    {
        return $this->type;
    }


    public function setType($type): void
    {
        $this->type = $type;
    }

    /**
     * @return ReasonDTO
     */
    public function getReason(): ReasonDTO
    {
        return $this->reason;
    }

    /**
     * @param ReasonDTO $reason
     */
    public function setReason(ReasonDTO $reason): void
    {
        $this->reason = $reason;
    }


    public function getSum()
    {
        return $this->sum;
    }


    /**
     * @param $sum
     * @throws \Exception
     */
    public function setSum($sum): void
    {
        //DTOValidator::validate(self::SUM_MIN_VALUE, self::SUM_MAX_VALUE, $sum, 'Sum');

        $this->sum = $sum;
    }

    public function getNotes()
    {
        return $this->notes;
    }


    /**
     * @param $notes
     * @throws \Exception
     */
    public function setNotes($notes): void
    {
       // DTOValidator::validate(self::NOTES_MIN_LENGTH, self::NOTES_MAX_LENGTH, $notes, 'Notes');

        $this->notes = $notes;
    }


    public function getOnDate()
    {
        return $this->onDate;
    }


    public function setOnDate($onDate): void
    {
        $this->onDate = $onDate;
    }


    public function getForDate()
    {
        return $this->forDate;
    }


    public function setForDate($forDate): void
    {
        $this->forDate = $forDate;
    }

    /**
     * @return UserDTO
     */
    public function getUser(): UserDTO
    {
        return $this->user;
    }

    /**
     * @param UserDTO $user
     */
    public function setUser(UserDTO $user): void
    {
        $this->user = $user;
    }
}