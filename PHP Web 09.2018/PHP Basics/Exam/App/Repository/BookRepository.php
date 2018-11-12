<?php

namespace App\Repository;


use App\DTO\BookDTO;
use App\DTO\GenreDTO;
use App\DTO\UserDTO;
use Core\DataBinderInterface;
use Database\DatabaseInterface;

class BookRepository implements BookRepositoryInterface
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
     * @return \Generator|BookDTO[]
     */
    public function findAll(): \Generator
    {
        /**
         * @var BookDTO $result
         */
        $result = $this->db
            ->query('SELECT book_id AS bookId, title, author, description, image, added_on AS addedOn, 
                            u.user_id AS userId, u.username, u.password, u.full_name AS fullName, u.born_on AS bornOn,
                            g.genre_id AS reasonId, g.name
                                FROM books b
                                INNER JOIN users u ON b.user_id = u.user_id
                                INNER JOIN genres g ON b.genre_id = g.genre_id
                               ')
            ->execute()
            ->fetchAll();

        foreach ($result as $row) {
            /**
             * @var BookDTO $book
             */
            $book = $this->dataBinder->bind($row, BookDTO::class);
            $user = $this->dataBinder->bind($row, UserDTO::class);
            $genre = $this->dataBinder->bind($row, GenreDTO::class);
            $book->setGenre($genre);
            $book->setUser($user);

            yield $book;
        }
    }

    public function findOneById(int $id): ?BookDTO
    {
        $result = $this->db->
        query('SELECT book_id AS bookId, title, author, description, image, added_on AS addedOn,
                           u.user_id AS userId, u.username, u.password, u.full_name AS fullName, u.born_on AS bornOn,
                            g.genre_id AS reasonId, g.name
                                FROM books b
                               INNER JOIN users u ON b.user_id = u.user_id
                                INNER JOIN genres g ON b.genre_id = g.genre_id
                                WHERE book_id = ?')
            ->execute([$id])
            ->fetchAll()
            ->current();

        /**
         * @var BookDTO $book
         */
        $book = $this->dataBinder->bind($result, BookDTO::class);
        $user = $this->dataBinder->bind($result, UserDTO::class);
        $genre = $this->dataBinder->bind($result, GenreDTO::class);
        $book->setGenre($genre);
        $book->setUser($user);

        return $book;
    }

    /**
     * @param int $userId
     * @return \Generator|BookDTO[]
     */
    public function findAllByUserId(int $userId): \Generator
    {
        /**
         * @var BookDTO $result
         */
        $result = $this->db
            ->query('SELECT book_id AS bookId, title, author, description, image, added_on AS addedOn, 
                            u.user_id AS userId, u.username, u.password, u.full_name AS fullName, u.born_on AS bornOn,
                            g.genre_id AS reasonId, g.name
                                FROM books b
                                INNER JOIN users u ON b.user_id = u.user_id
                                INNER JOIN genres g ON b.genre_id = g.genre_id
                                WHERE U.user_id = ?
                               ')
            ->execute([$userId])
            ->fetchAll();

        foreach ($result as $row) {
            /**
             * @var BookDTO $book
             */
            $book = $this->dataBinder->bind($row, BookDTO::class);
            $user = $this->dataBinder->bind($row, UserDTO::class);
            $genre = $this->dataBinder->bind($row, GenreDTO::class);
            $book->setGenre($genre);
            $book->setUser($user);

            yield $book;
        }
    }

    public function insert(BookDTO $bookDTO): bool
    {
        $this->db->query('INSERT INTO books (title, author, description, image, genre_id, user_id, added_on)
                                      VALUES (?, ?, ?, ?, ?, ?, ?)')
            ->execute([
                $bookDTO->getTitle(),
                $bookDTO->getAuthor(),
                $bookDTO->getDescription(),
                $bookDTO->getImage(),
                $bookDTO->getGenre()->getGenreId(),
                $bookDTO->getUser()->getUserId(),
                $bookDTO->getAddedOn()
            ]);

        return true;
    }

    public function update(BookDTO $bookDTO, int $id): bool
    {
        $this->db->query('UPDATE books
            SET title = ?, author = ?, description = ?, image = ?, genre_id = ?, user_id = ?, added_on = ?
            WHERE book_id = ?')
            ->execute([
                $bookDTO->getTitle(),
                $bookDTO->getAuthor(),
                $bookDTO->getDescription(),
                $bookDTO->getImage(),
                $bookDTO->getGenre()->getGenreId(),
                $bookDTO->getUser()->getUserId(),
                $bookDTO->getAddedOn(),
                $id
            ]);

        return true;
    }

    public function delete(int $id): bool
    {
        $this->db->query('DELETE FROM books
                                WHERE book_id = ?')
            ->execute([$id]);

        return true;
    }
}