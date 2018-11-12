<?php

namespace MyMoney\Http;



use MyMoney\Service\OperationServiceInterface;

class HomeHttpHandler extends HttpHandlerAbstract
{
    public function index()
    {
        if (isset($_SESSION['id'])) {
            $this->redirect('operations.php');
        } else {
            $this->render('home/index');
        }
    }

    public function operations(OperationServiceInterface $operationService)
    {
        if (!isset($_SESSION['id'])) {
            $this->redirect('index.php');
        }

        $this->render('operations/operations', $operationService->getAll());
    }
}