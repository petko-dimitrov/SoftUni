<?php

namespace MyMoney\Http;


use MyMoney\DTO\OperationDTO;
use MyMoney\DTO\OperationFormDTO;
use MyMoney\Service\OperationServiceInterface;
use MyMoney\Service\ReasonServiceInterface;
use MyMoney\Service\UserServiceInterface;

class OperationHttpHandler extends HttpHandlerAbstract
{
    public function addOperation (OperationServiceInterface $operationService,
                                  ReasonServiceInterface $reasonService, UserServiceInterface $userService, array $formData = [])
    {
        if (isset($_POST['add'])) {
            $this->handleAddProcess($operationService, $reasonService, $userService, $formData);
        } else {
            $operation = $this->dataBinder->bind($formData, OperationDTO::class);
            $reasons = $reasonService->getAll();
            $data = new OperationFormDTO();
            $data->setOperation($operation);
            $data->setReasons($reasons);
            $this->render('operations/add', $data);
        }
    }

    public function editOperation (OperationServiceInterface $operationService,
                                   ReasonServiceInterface $reasonService,
                                   UserServiceInterface $userService, array $formData = [], array $getData = [])
    {
        if (isset($_POST['edit'])) {
            $this->handleEditProcess($operationService, $reasonService, $userService, $formData, $getData);
        } else {
            $operation = $operationService->findOneById($getData['id']);
            $reasons = $reasonService->getAll();
            $data = new OperationFormDTO();
            $data->setOperation($operation);
            $data->setReasons($reasons);
            $this->render('operations/edit', $data);
        }
    }

    public function deleteOperation (OperationServiceInterface $operationService, array $getData = [])
    {
        $operationService->delete($getData['id']);
        $this->redirect('operations.php');
    }

    public function statistics(OperationServiceInterface $operationService)
    {
        $stats = $operationService->statistics();
        $this->render('operations/statistics', $stats);
    }

    private function handleAddProcess(OperationServiceInterface $operationService, ReasonServiceInterface $reasonService,
                                      UserServiceInterface $userService, array $formData = [])
    {
        try {
            $author = $userService->getCurrentUser();
            $reason = $reasonService->getOne($formData['reasonId']);

            /**
             * @var OperationDTO $operation
             */
            $operation = $this->dataBinder->bind($formData, OperationDTO::class);
            $operation->setUser($author);
            $operation->setReason($reason);
            $operation->setOnDate(date("Y-m-d H:i:s"));
            $operationService->add($operation);
            $_SESSION['last'] = $operation->getOnDate();
            $this->redirect('operations.php');
        } catch (\Exception $e) {
            $operationForm = $this->refillForm($reasonService, $formData);
            $this->render('operations/add', $operationForm, [$e->getMessage()]);
        }

    }

    private function handleEditProcess(OperationServiceInterface $operationService, ReasonServiceInterface $reasonService,
                                       UserServiceInterface $userService, array $formData = [], array $getData = [])
    {
        try {
            $author = $userService->getCurrentUser();
            $reason = $reasonService->getOne($formData['reasonId']);

            /**
             * @var OperationDTO $operation
             */
            $operation = $this->dataBinder->bind($formData, OperationDTO::class);
            $operation->setUser($author);
            $operation->setReason($reason);
            $operation->setOnDate(date("Y-m-d H:i:s"));
            $operationService->edit($operation, $getData['id']);
            $_SESSION['last'] = $operation->getOnDate();
            $this->redirect('operations.php');
        } catch (\Exception $e) {
            $operationForm = $this->refillForm($reasonService, $formData);
            $this->render('operations/edit', $operationForm, [$e->getMessage()]);
        }
    }

    /**
     * @param ReasonServiceInterface $reasonService
     * @param array $formData
     * @return OperationFormDTO
     */
    private function refillForm(ReasonServiceInterface $reasonService, array $formData): OperationFormDTO
    {
        /**
         * @var OperationDTO $operation
         */
        $operation = $this->dataBinder->bind($formData, OperationDTO::class);
        $reasonId = $formData['reasonId'];
        $reason = $reasonService->getOne($reasonId);
        $operation->setReason($reason);
        $reasons = $reasonService->getAll();
        $operationForm = new OperationFormDTO();
        $operationForm->setOperation($operation);
        $operationForm->setReasons($reasons);
        return $operationForm;
    }

}