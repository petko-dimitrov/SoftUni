<?php

namespace App\Service;


use App\DTO\BookDTO;
use App\Repository\BookRepositoryInterface;

class BookService implements BookServiceInterface
{
    /**
     * @var BookRepositoryInterface
     */
    private $bookRepository;

    /**
     * BookService constructor.
     * @param BookRepositoryInterface $bookRepository
     */
    public function __construct(BookRepositoryInterface $bookRepository)
    {
        $this->bookRepository = $bookRepository;
    }


    /**
     * @return \Generator|BookDTO[]
     */
    public function getAll(): \Generator
    {
        return $this->bookRepository->findAll();
    }

    public function getOneById(int $id): ?BookDTO
    {
        return $this->bookRepository->findOneById($id);
    }

    /**
     * @param int $userId
     * @return \Generator|BookDTO[]
     */
    public function getAllByUserId(int $userId): \Generator
    {
        return $this->bookRepository->findAllByUserId($userId);
    }

    /**
     * @param BookDTO $bookDTO
     * @return bool
     * @throws \Exception
     */
    public function add(BookDTO $bookDTO): bool
    {
        $this->validate($bookDTO);

        return $this->bookRepository->insert($bookDTO);
    }

    /**
     * @param BookDTO $bookDTO
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function edit(BookDTO $bookDTO, int $id): bool
    {
        if ($this->bookRepository->findOneById($id) == null) {
            throw new \Exception('Book does not exist!');
        }

        $this->validate($bookDTO);

        return $this->bookRepository->update($bookDTO, $id);
    }

    /**
     * @param int $id
     * @return bool
     * @throws \Exception
     */
    public function delete(int $id): bool
    {
        if ($this->bookRepository->findOneById($id) == null) {
            throw new \Exception('Book does not exist!');
        }

        return $this->bookRepository->delete($id);
    }

    /**
     * @param BookDTO $bookDTO
     * @throws \Exception
     */
    private function validate(BookDTO $bookDTO): void
    {
        if (mb_strlen($bookDTO->getTitle()) < 3 || mb_strlen($bookDTO->getTitle()) > 50) {
            throw new \Exception('Title must be between 3 and 50 symbols!');
        }

        if (mb_strlen($bookDTO->getAuthor()) < 3 || mb_strlen($bookDTO->getAuthor()) > 50) {
            throw new \Exception('Author must be between 3 and 50 symbols!');
        }

        if (mb_strlen($bookDTO->getDescription()) < 10 || mb_strlen($bookDTO->getDescription()) > 10000) {
            throw new \Exception('Description must be between 10 and 10000 symbols!');
        }

        if (mb_strlen($bookDTO->getImage()) < 3 || mb_strlen($bookDTO->getImage()) > 255) {
            throw new \Exception('Image URL must be between 3 and 255 symbols!');
        }
    }
}