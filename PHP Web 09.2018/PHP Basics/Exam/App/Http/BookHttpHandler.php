<?php

namespace App\Http;


use App\DTO\BookDTO;
use App\DTO\BookFormDTO;
use App\Service\BookServiceInterface;
use App\Service\GenreServiceInterface;
use App\Service\UserServiceInterface;

class BookHttpHandler extends HttpHandlerAbstract
{
    public function allBooks(BookServiceInterface $bookService)
    {
        if (!isset($_SESSION['id'])) {
            $this->redirect('index.php');
        }

        $this->render('books/allBooks', $bookService->getAll());
    }

    public function myBooks(BookServiceInterface $bookService)
    {
        if (!isset($_SESSION['id'])) {
            $this->redirect('index.php');
        }

        $this->render('books/myBooks', $bookService->getAllByUserId($_SESSION['id']));
    }

    public function addBook (BookServiceInterface $bookService, GenreServiceInterface $genreService,
                             UserServiceInterface $userService, array $formData = [])
    {
        if (isset($_POST['add'])) {
            $this->handleAddProcess($bookService, $genreService, $userService, $formData);
        } else {
            $book = $this->dataBinder->bind($formData, BookDTO::class);
            $genres = $genreService->getAll();
            $data = new BookFormDTO();
            $data->setBook($book);
            $data->setGenres($genres);
            $this->render('books/add', $data);
        }
    }

    public function editBook(BookServiceInterface $bookService, GenreServiceInterface $genreService,
                             UserServiceInterface $userService, array $formData = [], array $getData = [])
    {
        if (isset($_POST['edit'])) {
            $this->handleEditProcess($bookService, $genreService, $userService, $formData, $getData);
        } else {
            $book = $bookService->getOneById($getData['id']);
            $genres = $genreService->getAll();
            $data = new BookFormDTO();
            $data->setBook($book);
            $data->setGenres($genres);
            $this->render('books/edit', $data);
        }
    }

    public function deleteBook (BookServiceInterface $bookService, array $getData = [])
    {
        $bookService->delete($getData['id']);
        $this->redirect('my_books.php');
    }

    public function view (BookServiceInterface $bookService, array $getData = [])
    {
        $book = $bookService->getOneById($getData['id']);
        $this->render('books/view', $book);
    }

    private function handleAddProcess(BookServiceInterface $bookService, GenreServiceInterface $genreService,
                                      UserServiceInterface $userService, array $formData = [])
    {
        try {
            $user = $userService->getCurrentUser();
            $genre = $genreService->getOne($formData['genre_id']);
            /**
             * @var BookDTO $book
             */
            $book = $this->dataBinder->bind($formData, BookDTO::class);
            $book->setUser($user);
            $book->setGenre($genre);
            $book->setAddedOn(date("Y-m-d H:i:s"));
            $bookService->add($book);

            $this->redirect('my_books.php');
        } catch (\Exception $e) {
            $bookForm = $this->refillForm($genreService, $formData);
            $this->render('books/add', $bookForm, [$e->getMessage()]);
        }
    }

    private function handleEditProcess(BookServiceInterface $bookService, GenreServiceInterface $genreService,
                                       UserServiceInterface $userService, array $formData = [], array $getData = [])
    {
        try {
            $user = $userService->getCurrentUser();
            $genre = $genreService->getOne($formData['genre_id']);

            /**
             * @var BookDTO $book
             */
            $book = $this->dataBinder->bind($formData, BookDTO::class);
            $book->setUser($user);
            $book->setGenre($genre);
            $bookService->edit($book, $getData['id']);

            $this->redirect('my_books.php');
        } catch (\Exception $e) {
            $bookForm = $this->refillForm($genreService, $formData);
            $this->render('books/edit', $bookForm, [$e->getMessage()]);
        }
    }


    /**
     * @param GenreServiceInterface $genreService
     * @param array $formData
     * @return BookFormDTO
     */
    private function refillForm(GenreServiceInterface $genreService, array $formData): BookFormDTO
    {
        /**
         * @var BookDTO $book
         */
        $book = $this->dataBinder->bind($formData, BookDTO::class);
        $genreId = $formData['genre_id'];
        $genre = $genreService->getOne($genreId);
        $book->setGenre($genre);
        $genres = $genreService->getAll();
        $bookForm = new BookFormDTO();
        $bookForm->setBook($book);
        $bookForm->setGenres($genres);
        return $bookForm;
    }

}