<?php /** @var \App\DTO\UserDTO $data */?>

<h1>Hello, <?=$data->getFullName()?></h1>

<p><a href="add_book.php">Add new book</a> | <a href="logout.php">logout</a></p>
<a href="my_books.php">My Books</a><br />
<a href="all_books.php">All Books</a>
