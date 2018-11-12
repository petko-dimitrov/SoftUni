<?php /** @var \MyMoney\DTO\OperationFormDTO $data*/ ?>

<h1>Add new operation</h1>
<?php foreach ($errors as $error): ?>
    <p style="color: red"><?=$error?></p>
<?php endforeach;?>

<form method="post">
    <div>
        <label for="type">Type:</label>
        <select name="type">
            <option value="O">Expense</option>
            <?php if ($data->getOperation()->getType() == 'I'):?>
                <option selected="selected" value="I">Income</option>
            <?php else:?>
                <option value="I">Income</option>
            <?php endif;?>
        </select>
    </div>
    <div>
        <label for="reasonId">Reason:</label>
        <select name="reasonId">
            <?php foreach ($data->getReasons() as $reason): ?>
                <?php if ($data->getOperation()->getReason()->getReasonId() != null
                    && $data->getOperation()->getReason()->getReasonId() == $reason->getReasonId()):?>
                    <option selected="selected" value="<?=$reason->getReasonId()?>"><?=$reason->getName()?></option>
                <?php else: ?>
                    <option value="<?=$reason->getReasonId()?>"><?=$reason->getName()?></option>
                <?php endif;?>
            <?php endforeach; ?>
        </select>
    </div>
    <div>
        <label for="sum">Sum:</label>
        <input type="number" step="0.01" name="sum" value="<?=$data != null ? $data->getOperation()->getSum() : ""?>">
    </div>
    <div>
        <label for="notes">Notes:</label>
        <input type="text" name="notes" value="<?=$data != null ? $data->getOperation()->getNotes() : ""?>">
    </div>
    <div>
        <label for="forDate">For Date:</label>
        <input type="date" name="forDate" value="<?=$data != null ? $data->getOperation()->getForDate() : ""?>">
    </div>
    <div>
        <input type="submit" name="add" value="Save">
    </div>
</form>

<p><a href="operations.php">List</a></p>