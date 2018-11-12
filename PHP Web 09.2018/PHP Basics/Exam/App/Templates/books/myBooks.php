<?php /** @var \App\DTO\BookDTO[] $data */ ?>

<h1>My Books</h1>
<p><a href="add_book.php">Add new book</a> | <a href="profile.php">My Profile</a> | <a href="logout.php">logout</a></p>
<table border="1">
    <thead>
        <tr>
            <th>Title</th>
            <th>Author</th>
            <th>Genre</th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
        <?php foreach ($data as $row): ?>
            <tr>
                <td><?=$row->getTitle()?></td>
                <td><?=$row->getAuthor()?></td>
                <td><?=$row->getGenre()->getName()?></td>
                <td><a href="edit.php?id=<?=$row->getBookId()?>">edit book</a></td>
                <td><a href="delete.php?id=<?=$row->getBookId()?>">delete book</a></td>
            </tr>
        <?php endforeach; ?>
    </tbody>
</table>
