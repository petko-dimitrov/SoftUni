<?php /** @var \MyMoney\DTO\StatisticsDTO[] $data*/ ?>

<h1>Statistics</h1>

<table border="1">
    <thead>
    <tr>
        <th>Reasons</th>
        <th>Operations</th>
        <th>Total</th>
    </tr>
    </thead>
    <tbody>
    <?php foreach ($data as $row): ?>
        <tr>
            <td><?=$row->getReason()?></td>
            <td><?=$row->getCount()?></td>
            <td><?=floor($row->getSum()) == $row->getSum() ? floor($row->getSum()) : number_format($row->getSum(), 2, '.', '')?></td>
        </tr>
    <?php endforeach; ?>
    </tbody>
</table>
<ul>
    <li><a href="operations.php">List</a></li>
    <li><a href="addOperation.php">Add new operation</a></li>
    <li><a href="logout.php">Logout</a></li>
</ul>