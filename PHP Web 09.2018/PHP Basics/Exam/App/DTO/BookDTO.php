<?php

namespace App\DTO;


class BookDTO
{
    private $bookId;

    private $title;

    private $author;

    private $description;

    private $image;

    /**
     * @var GenreDTO
     */
    private $genre;

    /**
     * @var UserDTO
     */
    private $user;

    private $addedOn;


    public function getBookId()
    {
        return $this->bookId;
    }


    public function setBookId($bookId): void
    {
        $this->bookId = $bookId;
    }


    public function getTitle()
    {
        return $this->title;
    }

    public function setTitle($title): void
    {
        $this->title = $title;
    }


    public function getAuthor()
    {
        return $this->author;
    }


    public function setAuthor($author): void
    {
        $this->author = $author;
    }


    public function getDescription()
    {
        return $this->description;
    }


    public function setDescription($description): void
    {
        $this->description = $description;
    }


    public function getImage()
    {
        return $this->image;
    }


    public function setImage($image): void
    {
        $this->image = $image;
    }

    /**
     * @return GenreDTO
     */
    public function getGenre(): GenreDTO
    {
        return $this->genre;
    }

    /**
     * @param GenreDTO $genre
     */
    public function setGenre(GenreDTO $genre): void
    {
        $this->genre = $genre;
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


    public function getAddedOn()
    {
        return $this->addedOn;
    }


    public function setAddedOn($addedOn): void
    {
        $this->addedOn = $addedOn;
    }


}