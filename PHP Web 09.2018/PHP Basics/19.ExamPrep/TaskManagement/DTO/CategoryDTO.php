<?php

namespace TaskManagement\DTO;


class CategoryDTO
{
    const NAME_MIN_LENGTH = 3;
    const NAME_MAX_LENGTH = 50;

    private $categoryId;

    private $name;

    public function getCategoryId()
    {
        return $this->categoryId;
    }

    public function setCategoryId($categoryId): void
    {
        $this->categoryId = $categoryId;
    }

    public function getName()
    {
        return $this->name;
    }

    /**
     * @param $name
     * @throws \Exception
     */
    public function setName($name): void
    {
        DTOValidator::validate(self::NAME_MIN_LENGTH, self::NAME_MAX_LENGTH, $name, 'Invalid name!');

        $this->name = $name;
    }


}