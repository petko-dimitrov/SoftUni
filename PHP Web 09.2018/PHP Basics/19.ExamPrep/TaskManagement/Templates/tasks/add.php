<?php /** @var \TaskManagement\DTO\CategoryDTO[] $data */?>

<h1>Add New Task</h1>

<form method="post">
    <div>
        <label for="title">Title:</label>
        <input type="text" name="title" minlength="3" maxlength="50">
    </div>
    <div>
        <label for="categoryId">Category:</label>
        <select name="categoryId">
            <?php foreach ($data as $category): ?>
                <option value="<?=$category->getCategoryId()?>"><?=$category->getName()?></option>
            <?php endforeach; ?>
        </select>
    </div>
    <div>
        <label for="description">Description:</label>
        <input type="text" name="description" minlength="10" maxlength="10000">
    </div>
    <div>
        <label for="location">Location:</label>
        <input type="text" name="location" minlength="3" maxlength="100">
    </div>
    <div>
        <label for="startedOn">Started on:</label>
        <input type="date" name="startedOn">
    </div>
    <div>
        <label for="dueDate">Due date:</label>
        <input type="date" name="dueDate">
    </div>
    <div>
        <input type="submit" name="add" value="Save">
    </div>
</form>

<p><a href="dashboard.php">List</a></p>