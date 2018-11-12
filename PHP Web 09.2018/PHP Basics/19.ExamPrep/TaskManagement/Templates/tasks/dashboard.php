<?php /** @var \TaskManagement\DTO\TaskDTO[] $data */ ?>
<h1>All Tasks</h1>
<p><a href="addTask.php">Add new task</a> | <a href="logout.php">logout</a></p>
<table border="1">
    <thead>
    <tr>
        <th>Title</th>
        <th>Category</th>
        <th>Author</th>
        <th>Edit</th>
        <th>Delete</th>
    </tr>
    </thead>
    <tbody>
    <?php foreach ($data as $row): ?>
        <tr>
            <td><?= $row->getTitle() ?></td>
            <td><?= $row->getCategory()->getName() ?></td>
            <td><?= $row->getAuthor()->getUsername() ?></td>
            <td><a href="editTask.php?id=<?= $row->getTaskId() ?>">edit task</a></td>
            <td><a href="deleteTask.php?id=<?= $row->getTaskId() ?>">delete task</a></td>
        </tr>
    <?php endforeach; ?>
    </tbody>
</table>