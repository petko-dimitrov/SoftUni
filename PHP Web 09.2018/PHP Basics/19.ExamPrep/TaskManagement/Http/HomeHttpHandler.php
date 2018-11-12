<?php

namespace TaskManagement\Http;


use TaskManagement\Service\TaskServiceInterface;

class HomeHttpHandler extends HttpHandlerAbstract
{
    public function index()
    {
        if (isset($_SESSION['id'])) {
            $this->redirect('dashboard.php');
        } else {
            $this->render('home/index');
        }
    }

    public function dashboard(TaskServiceInterface $taskService)
    {
        if (!isset($_SESSION['id'])) {
            $this->redirect('index.php');
        }

        $this->render('tasks/dashboard', $taskService->getAll());
    }
}