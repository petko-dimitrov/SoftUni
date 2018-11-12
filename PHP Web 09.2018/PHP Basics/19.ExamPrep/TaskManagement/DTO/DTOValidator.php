<?php

namespace TaskManagement\DTO;


class DTOValidator
{
    /**
     * @param int $min
     * @param int $max
     * @param string $property
     * @param string $errorMsg
     * @throws \Exception
     */
    public static function validate(int $min, int $max, string $property, string $errorMsg)
    {
        if (mb_strlen($property) < $min || mb_strlen($property) > $max) {
            throw new \Exception($errorMsg);
        }
    }
}