<?php /** @var \TaskManagement\DTO\EditTaskDTO $data */ ?>

<h1>Edit Task "<?= $data->getTask()->getTitle() ?>"</h1>

<form method="post">
    <div>
        <label for="title">Title:</label>
        <input type="text" name="title" minlength="3" maxlength="50" value="<?= $data->getTask()->getTitle() ?>">
    </div>
    <div>
        <label for="categoryId">Category:</label>
        <select name="categoryId">
            <?php foreach ($data->getCategories() as $category): ?>
                <?php if ($data->getTask()->getCategory()->getCategoryId() == $category->getCategoryId()):?>
                <option selected="selected" value="<?=$category->getCategoryId()?>"><?=$category->getName()?></option>
                <?php else: ?>
                <option value="<?=$category->getCategoryId()?>"><?=$category->getName()?></option>
                <?php endif;?>
            <?php endforeach; ?>
        </select>
    </div>
    <div>
        <label for="description">Description:</label>
        <input type="text" name="description" minlength="10" maxlength="10000" value="<?= $data->getTask()->getDescription() ?>">
    </div>
    <div>
        <label for="location">Location:</label>
        <input type="text" name="location" minlength="3" maxlength="100" value="<?= $data->getTask()->getLocation() ?>">
    </div>
    <div>
        <label for="startedOn">Started on:</label>
        <input type="date" name="startedOn" value="<?= $data->getTask()->getStartedOn() ?>">
    </div>
    <div>
        <label for="dueDate">Due date:</label>
        <input type="date" name="dueDate" value="<?= $data->getTask()->getDueDate() ?>">
    </div>
    <div>
        <input type="submit" name="edit" value="Save">
    </div>
</form>

<p><a href="dashboard.php">List</a></p>