<?php

namespace MyMoney\DTO;


class StatisticsDTO
{
    private $reason;

    private $count;

    private $sum;

    public function getReason()
    {
        return $this->reason;
    }

    public function setReason($reason): void
    {
        $this->reason = $reason;
    }

    public function getCount()
    {
        return $this->count;
    }

    public function setCount($count): void
    {
        $this->count = $count;
    }

    public function getSum()
    {
        return $this->sum;
    }

    public function setSum($sum): void
    {
        $this->sum = $sum;
    }


}