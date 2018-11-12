<?php

namespace App\Service;

use App\DTO\GenreDTO;
use App\Repository\GenreRepositoryInterface;

class GenreService implements GenreServiceInterface
{
    /**
     * @var GenreRepositoryInterface
     */
    private $genreRepository;

    /**
     * GenreService constructor.
     * @param GenreRepositoryInterface $genreRepository
     */
    public function __construct(GenreRepositoryInterface $genreRepository)
    {
        $this->genreRepository = $genreRepository;
    }


    /**
     * @return \Generator|GenreDTO[]
     */
    public function getAll(): \Generator
    {
       return $this->genreRepository->findAll();
    }

    public function getOne(int $id): GenreDTO
    {
        return $this->genreRepository->findOne($id);
    }
}