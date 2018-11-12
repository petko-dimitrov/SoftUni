<?php /** @var \MyMoney\DTO\OperationDTO[] $data */ ?>

<h1>All Operations</h1>
<table border="1">
    <thead>
        <tr>
            <th>Date</th>
            <th>Type</th>
            <th>Reason</th>
            <th>Sum</th>
            <th>Notes</th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
        <?php foreach ($data as $row): ?>
        <?php if(isset($_SESSION['last']) && $row->getOnDate() == $_SESSION['last']): ?>
            <tr style="background-color: lightgreen">
            <?php unset($_SESSION['last']) ?>
        <?php else:?>
            <tr>
        <?php endif;?>
            <td><?=$row->getForDate()?></td>
            <td>
                <?=$row->getType() == 'O' ? 'Expense' : 'Income'?>
            </td>
            <td><?=$row->getReason()->getName()?></td>
            <td><?=floor($row->getSum()) == $row->getSum() ? floor($row->getSum()) : number_format($row->getSum(), 2, ',', '')?></td>
            <td><?=$row->getNotes()?></td>
            <td><a href="editOperation.php?id=<?= $row->getOperationId() ?>">edit</a></td>
            <td><a href="deleteOperation.php?id=<?= $row->getOperationId() ?>">delete</a></td>
        </tr>
        <?php endforeach; ?>
    </tbody>
</table>
<ul>
    <li><a href="addOperation.php">Add new operation</a></li>
    <li><a href="statistics.php">Statistics</a></li>
    <li><a href="logout.php">Logout</a></li>
</ul>
