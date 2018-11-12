<?php

namespace MyMoney\DTO;


class DTOValidator
{
    /**
     * @param double $min
     * @param double $max
     * @param mixed $property
     * @param string $propertyName
     * @throws \Exception
     */
    public static function validate(float $min, float $max, $property, string $propertyName)
    {

        if ($propertyName === 'Sum') {
            $errorMsg = "$propertyName must be between $min and $max!";

            if ($property < $min || $property > $max) {
                throw new \Exception($errorMsg);
            }
        } else {
            $errorMsg = "$propertyName must be between $min and $max characters!";

            if (mb_strlen($property) < $min || mb_strlen($property) > $max) {
                throw new \Exception($errorMsg);
            }
        }
    }
}