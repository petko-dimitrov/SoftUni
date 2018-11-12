<?php

namespace App\DTO;


class GenreDTO
{
    private $genreId;

    private $name;

    public function getGenreId()
    {
        return $this->genreId;
    }

    public function setGenreId($genreId): void
    {
        $this->genreId = $genreId;
    }

    public function getName()
    {
        return $this->name;
    }

    /**
     * @param $name
     */
    public function setName($name): void
    {
        $this->name = $name;
    }

}