<?php

namespace MyMoney\Service;


use MyMoney\DTO\ReasonDTO;
use MyMoney\Repository\ReasonRepositoryInterface;

class ReasonService implements ReasonServiceInterface
{
    /**
     * @var ReasonRepositoryInterface
     */
    private $reasonRepository;

    /**
     * ReasonService constructor.
     * @param ReasonRepositoryInterface $reasonRepository
     */
    public function __construct(ReasonRepositoryInterface $reasonRepository)
    {
        $this->reasonRepository = $reasonRepository;
    }


    /**
     * @return \Generator|ReasonDTO[]
     */
    public function getAll(): \Generator
    {
        return $this->reasonRepository->findAll();
    }

    public function getOne(int $id): ReasonDTO
    {
        return $this->reasonRepository->findOne($id);
    }
}