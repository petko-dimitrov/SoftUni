<?php

namespace TaskManagement\DTO;


class TaskDTO
{
    const TITLE_MIN_LENGTH = 3;
    const TITLE_MAX_LENGTH = 50;
    const DESCRIPTION_MIN_LENGTH = 10;
    const DESCRIPTION_MAX_LENGTH = 10000;
    const LOCATION_MIN_LENGTH = 3;
    const LOCATION_MAX_LENGTH = 100;

    private $taskId;

    private $title;

    private $description;

    private $location;

    /**
     * @var UserDTO
     */
    private $author;

    /**
     * @var CategoryDTO
     */
    private $category;

    private $startedOn;

    private $dueDate;

    public function getTaskId()
    {
        return $this->taskId;
    }

    public function setTaskId($taskId): void
    {
        $this->taskId = $taskId;
    }

    public function getTitle()
    {
        return $this->title;
    }

    /**
     * @param $title
     * @throws \Exception
     */
    public function setTitle($title): void
    {
        DTOValidator::validate(self::TITLE_MIN_LENGTH, self::TITLE_MAX_LENGTH, $title, 'Invalid title!');

        $this->title = $title;
    }

    public function getDescription()
    {
        return $this->description;
    }

    /**
     * @param $description
     * @throws \Exception
     */
    public function setDescription($description): void
    {
        DTOValidator::validate(self::DESCRIPTION_MIN_LENGTH, self::DESCRIPTION_MAX_LENGTH, $description, 'Invalid description!');

        $this->description = $description;
    }

    public function getLocation()
    {
        return $this->location;
    }

    /**
     * @param $location
     * @throws \Exception
     */
    public function setLocation($location): void
    {
        DTOValidator::validate(self::LOCATION_MIN_LENGTH, self::LOCATION_MAX_LENGTH, $location, 'Invalid location!');

        $this->location = $location;
    }

    /**
     * @return UserDTO
     */
    public function getAuthor(): UserDTO
    {
        return $this->author;
    }

    /**
     * @param UserDTO $author
     */
    public function setAuthor(UserDTO $author): void
    {
        $this->author = $author;
    }

    /**
     * @return CategoryDTO
     */
    public function getCategory(): CategoryDTO
    {
        return $this->category;
    }

    /**
     * @param CategoryDTO $category
     */
    public function setCategory(CategoryDTO $category): void
    {
        $this->category = $category;
    }

    public function getStartedOn()
    {
        return $this->startedOn;
    }

    public function setStartedOn($startedOn): void
    {
        $this->startedOn = $startedOn;
    }

    public function getDueDate()
    {
        return $this->dueDate;
    }

    public function setDueDate($dueDate): void
    {
        $this->dueDate = $dueDate;
    }
}