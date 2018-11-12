<?php

namespace TaskManagement\Repository;


use Core\DataBinderInterface;
use Database\DatabaseInterface;
use TaskManagement\DTO\CategoryDTO;
use TaskManagement\DTO\TaskDTO;
use TaskManagement\DTO\UserDTO;

class TaskRepository implements TaskRepositoryInterface
{
    /**
     * @var DatabaseInterface
     */
    private $db;

    /**
     * @var DataBinderInterface
     */
    private $dataBinder;

    /**
     * TaskRepository constructor.
     * @param DatabaseInterface $db
     * @param DataBinderInterface $dataBinder
     */
    public function __construct(DatabaseInterface $db, DataBinderInterface $dataBinder)
    {
        $this->db = $db;
        $this->dataBinder = $dataBinder;
    }


    /**
     * @return \Generator|TaskDTO[]
     */
    public function findAll(): \Generator
    {
        /**
         * @var TaskDTO $result
         */
        $result =  $this->db
            ->query('SELECT task_id AS taskId, title, description, location, 
        u.user_id AS userId, u.username, u.password, u.first_name AS firsName, u.last_name AS lastName,
        c.category_id AS categoryId, c.name,
        started_on AS startedOn, due_date AS dueDate
                                FROM tasks t
                                INNER JOIN users u ON t.author_id = u.user_id
                                INNER JOIN categories c ON t.category_id = c.category_id
                                ORDER BY due_date, task_id ')
            ->execute()
            ->fetchAll();

        foreach ($result as $row) {
            /**
             * @var TaskDTO $task
             */
            $task = $this->dataBinder->bind($row, TaskDTO::class);
            $user = $this->dataBinder->bind($row, UserDTO::class);
            $category = $this->dataBinder->bind($row, CategoryDTO::class);
            $task->setAuthor($user);
            $task->setCategory($category);

            yield $task;
        }
    }

    public function findOneById(int $id): ?TaskDTO
    {
        $result = $this->db->query('SELECT task_id AS taskId, title, description, location, 
        u.user_id AS userId, u.username, u.password, u.first_name AS firsName, u.last_name AS lastName,
        c.category_id AS categoryId, c.name,
        started_on AS startedOn, due_date AS dueDate
                                FROM tasks t
                                INNER JOIN users u ON t.author_id = u.user_id
                                INNER JOIN categories c ON t.category_id = c.category_id
                                 WHERE t.task_id = ?')
            ->execute([$id])
            ->fetchAll()
            ->current();

        /**
         * @var TaskDTO $task
         */
        $task = $this->dataBinder->bind($result, TaskDTO::class);
        $user = $this->dataBinder->bind($result, UserDTO::class);
        $category = $this->dataBinder->bind($result, CategoryDTO::class);
        $task->setAuthor($user);
        $task->setCategory($category);

        return $task;
    }

    public function insert(TaskDTO $taskDTO): bool
    {
        $this->db->query('INSERT INTO tasks (title, description, location, author_id, category_id, started_on, due_date)
                                VALUES (?, ?, ?, ?, ?, ? , ?)')
            ->execute([
                $taskDTO->getTitle(),
                $taskDTO->getDescription(),
                $taskDTO->getLocation(),
                $taskDTO->getAuthor()->getUserId(),
                $taskDTO->getCategory()->getCategoryId(),
                $taskDTO->getStartedOn(),
                $taskDTO->getDueDate()
            ]);

        return true;
    }

    public function update(TaskDTO $taskDTO, int $id): bool
    {
        $this->db->query('UPDATE tasks 
                                SET title = ?, description = ?, location = ?, author_id = ?, category_id = ?, started_on = ?, due_date =?
                                WHERE task_id = ?')
            ->execute([
                $taskDTO->getTitle(),
                $taskDTO->getDescription(),
                $taskDTO->getLocation(),
                $taskDTO->getAuthor()->getUserId(),
                $taskDTO->getCategory()->getCategoryId(),
                $taskDTO->getStartedOn(),
                $taskDTO->getDueDate(),
                $id
            ]);

        return true;
    }

    public function delete(int $id): bool
    {
        $this->db->query('DELETE FROM tasks
                             WHERE task_id = ?')
            ->execute([$id]);

        return true;
    }
}