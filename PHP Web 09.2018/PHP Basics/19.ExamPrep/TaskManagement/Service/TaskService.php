<?php

namespace TaskManagement\Service;


use TaskManagement\DTO\TaskDTO;
use TaskManagement\Repository\TaskRepositoryInterface;

class TaskService implements TaskServiceInterface
{
    /**
     * @var TaskRepositoryInterface
     */
    private $taskRepository;

    /**
     * TaskService constructor.
     * @param TaskRepositoryInterface $taskRepository
     */
    public function __construct(TaskRepositoryInterface $taskRepository)
    {
        $this->taskRepository = $taskRepository;
    }


    /**
     * @return \Generator|TaskDTO[]
     */
    public function getAll(): \Generator
    {
        return $this->taskRepository->findAll();
    }

    public function findOneById(int $id): ?TaskDTO
    {
        return $this->taskRepository->findOneById($id);
    }

    public function add(TaskDTO $taskDTO): bool
    {
        return $this->taskRepository->insert($taskDTO);
    }

    /**
     * @param TaskDTO $taskDTO
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function edit(TaskDTO $taskDTO, int $id): bool
    {
        if ($this->findOneById($id) == null) {
            throw new \Exception('Task does not exist!');
        }

        return $this->taskRepository->update($taskDTO, $id);
    }

    /**
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function delete(int $id): bool
    {
        if ($this->findOneById($id) == null) {
            throw new \Exception('Task does not exist!');
        }

        return $this->taskRepository->delete($id);
    }
}