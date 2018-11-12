<?php

namespace MyMoney\Service;


use MyMoney\DTO\OperationDTO;
use MyMoney\Repository\OperationRepositoryInterface;

class OperationService implements OperationServiceInterface
{
    /**
     * @var OperationRepositoryInterface
     */
    private $operationRepository;

    /**
     * OperationService constructor.
     * @param OperationRepositoryInterface $operationRepository
     */
    public function __construct(OperationRepositoryInterface $operationRepository)
    {
        $this->operationRepository = $operationRepository;
    }


    /**
     * @return \Generator|OperationDTO[]
     */
    public function getAll(): \Generator
    {
        return $this->operationRepository->findAll();
    }

    public function findOneById(int $id): ?OperationDTO
    {
        return $this->operationRepository->findOneById($id);
    }


    /**
     * @param OperationDTO $operationDTO
     * @return bool
     * @throws \Exception
     */
    public function add(OperationDTO $operationDTO): bool
    {
        if ($operationDTO->getSum() < 0 || $operationDTO->getSum() >= 100000) {
            throw new \Exception('Sum must be between 0 and 99999,99!');
        }

        if (mb_strlen($operationDTO->getNotes()) < 0 || mb_strlen($operationDTO->getNotes()) > 255) {
            throw new \Exception('Notes must be between 0 and 255 symbols!');
        }

        return $this->operationRepository->insert($operationDTO);
    }

    /**
     * @param OperationDTO $operationDTO
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function edit(OperationDTO $operationDTO, int $id): bool
    {
        if ($this->findOneById($id) == null) {
        throw new \Exception('Operation does not exist!');
    }

        if ($operationDTO->getSum() < 0 || $operationDTO->getSum() >= 100000) {
            throw new \Exception('Sum must be between 0 and 99999,99!');
        }

        if (mb_strlen($operationDTO->getNotes()) < 0 || mb_strlen($operationDTO->getNotes()) > 255) {
            throw new \Exception('Notes must be between 0 and 255 symbols!');
        }

        return $this->operationRepository->update($operationDTO, $id);
    }

    /**
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function delete(int $id): bool
    {
        if ($this->findOneById($id) == null) {
            throw new \Exception('Operation does not exist!');
        }

        return $this->operationRepository->delete($id);
    }

    public function statistics(): \Generator
    {
        return $this->operationRepository->findStatistics();
    }
}