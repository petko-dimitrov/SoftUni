<?php

namespace App\DTO;


class BookFormDTO
{
    /**
     * @var BookDTO
     */
    private $book;

    /**
     * @var GenreDTO[]
     */
    private $genres;

    /**
     * @return BookDTO
     */
    public function getBook(): BookDTO
    {
        return $this->book;
    }

    /**
     * @param BookDTO $book
     */
    public function setBook(BookDTO $book): void
    {
        $this->book = $book;
    }


    public function getGenres()
    {
        return $this->genres;
    }


    public function setGenres($genres): void
    {
        $this->genres = $genres;
    }


}