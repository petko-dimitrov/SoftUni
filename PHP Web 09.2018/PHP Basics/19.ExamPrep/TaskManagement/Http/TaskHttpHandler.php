<?php

namespace TaskManagement\Http;


use TaskManagement\DTO\EditTaskDTO;
use TaskManagement\DTO\TaskDTO;
use TaskManagement\Service\CategoryServiceInterface;
use TaskManagement\Service\TaskServiceInterface;
use TaskManagement\Service\UserServiceInterface;

class TaskHttpHandler extends HttpHandlerAbstract
{
    public function addTask(TaskServiceInterface $taskService, CategoryServiceInterface $categoryService,
                            UserServiceInterface $userService, array $formData = [])
    {
        if (isset($_POST['add'])) {
            $this->handleAddProcess($taskService, $categoryService, $userService, $formData);
        } else {
            $data = $categoryService->getAll();
            $this->render('tasks/add', $data);
        }
    }

    public function editTask(TaskServiceInterface $taskService, CategoryServiceInterface $categoryService,
                             UserServiceInterface $userService, array $formData = [], array $getData = [])
    {
        if (isset($_POST['edit'])) {
            $this->handleEditProcess($taskService, $categoryService, $userService, $formData, $getData);
        } else {
            $task = $taskService->findOneById($getData['id']);
            $editDTO = new EditTaskDTO();
            $editDTO->setTask($task);
            $editDTO->setCategories($categoryService->getAll());

            $this->render('tasks/edit', $editDTO);
        }
    }

    public function deleteTask(TaskServiceInterface $taskService, array $getData = [])
    {
        $taskService->delete($getData['id']);
        $this->redirect('dashboard.php');
    }

    private function handleAddProcess(TaskServiceInterface $taskService,  CategoryServiceInterface $categoryService,
                                      UserServiceInterface $userService, array $formData = [])
    {
        $author = $userService->getCurrentUser();
        $category = $categoryService->getOne($formData['categoryId']);
        /**
         * @var TaskDTO $task
         */
        $task = $this->dataBinder->bind($formData, TaskDTO::class);
        $task->setAuthor($author);
        $task->setCategory($category);
        $taskService->add($task);

        $this->redirect('dashboard.php');
    }

    private function handleEditProcess(TaskServiceInterface $taskService,  CategoryServiceInterface $categoryService,
                                       UserServiceInterface $userService, array $formData = [], array $getData)
    {
        $author = $userService->getCurrentUser();
        $category = $categoryService->getOne($formData['categoryId']);
        /**
         * @var TaskDTO $task
         */
        $task = $this->dataBinder->bind($formData, TaskDTO::class);
        $task->setAuthor($author);
        $task->setCategory($category);
        $taskService->edit($task, $getData['id']);

        $this->redirect('dashboard.php');
    }
}