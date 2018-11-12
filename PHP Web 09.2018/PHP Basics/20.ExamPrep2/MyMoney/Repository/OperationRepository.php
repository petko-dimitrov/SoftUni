<?php

namespace MyMoney\Repository;


use Core\DataBinderInterface;
use Database\DatabaseInterface;
use MyMoney\DTO\OperationDTO;
use MyMoney\DTO\ReasonDTO;
use MyMoney\DTO\StatisticsDTO;
use MyMoney\DTO\UserDTO;

class OperationRepository implements OperationRepositoryInterface
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
     * @return \Generator|OperationDTO[]
     */
    public function findAll(): \Generator
    {
        /**
         * @var OperationDTO $result
         */
        $result =  $this->db
            ->query('SELECT operation_id AS operationId, type, sum, notes, on_date AS onDate,  for_date AS forDate,
                            u.user_id AS userId, u.username, u.password, u.full_name AS fullName, u.born_on AS bornOn,
                            r.reason_id AS reasonId, r.name
                                FROM operations o
                                INNER JOIN users u ON o.user_id = u.user_id
                                INNER JOIN reasons r ON o.reason_id = r.reason_id
                                ORDER BY 
                                DATE(for_date) = DATE(NOW()) DESC,
                                IF(DATE(for_date) = DATE(NOW()),
                                for_date, DATE(NULL)) DESC,
                                for_date ASC')
            ->execute()
            ->fetchAll();

        foreach ($result as $row) {
            /**
             * @var OperationDTO $operation
             */
            $operation = $this->dataBinder->bind($row, OperationDTO::class);
            $user = $this->dataBinder->bind($row, UserDTO::class);
            $reason = $this->dataBinder->bind($row, ReasonDTO::class);
            $operation->setReason($reason);
            $operation->setUser($user);

            yield $operation;
        }
    }

    public function findOneById(int $id): ?OperationDTO
    {
        $result = $this->db->
        query('SELECT operation_id AS operationId, type, sum, notes, on_date AS onDate,  for_date AS forDate,
                            u.user_id AS userId, u.username, u.password, u.full_name AS fullName, u.born_on AS bornOn,
                            r.reason_id AS reasonId, r.name
                                FROM operations o
                                INNER JOIN users u ON o.user_id = u.user_id
                                INNER JOIN reasons r ON o.reason_id = r.reason_id
                                WHERE operation_id = ?')
            ->execute([$id])
            ->fetchAll()
            ->current();

        /**
         * @var OperationDTO $operation
         */
        $operation = $this->dataBinder->bind($result, OperationDTO::class);
        $user = $this->dataBinder->bind($result, UserDTO::class);
        $reason = $this->dataBinder->bind($result, ReasonDTO::class);
        $operation->setReason($reason);
        $operation->setUser($user);

        return $operation;
    }

    public function insert(OperationDTO $operationDTO): bool
    {
        $this->db->query('INSERT INTO operations (type, reason_id, sum, notes, on_date, for_date, user_id)
                                      VALUES (?, ?, ?, ?, ?, ?, ?)')
            ->execute([
                $operationDTO->getType(),
                $operationDTO->getReason()->getReasonId(),
                $operationDTO->getSum(),
                $operationDTO->getNotes(),
                $operationDTO->getOnDate(),
                $operationDTO->getForDate(),
                $operationDTO->getUser()->getUserId()
            ]);

        return true;
    }

    public function update(OperationDTO $operationDTO, int $id): bool
    {
        $this->db->query('UPDATE operations 
                      SET type = ?, reason_id = ?, sum = ?, notes = ?, on_date = ?, for_date = ?, user_id = ?
                                   WHERE operation_id = ?')
            ->execute([
                $operationDTO->getType(),
                $operationDTO->getReason()->getReasonId(),
                $operationDTO->getSum(),
                $operationDTO->getNotes(),
                $operationDTO->getOnDate(),
                $operationDTO->getForDate(),
                $operationDTO->getUser()->getUserId(),
                $id
            ]);

        return true;
    }

    public function delete(int $id): bool
    {
        $this->db->query('DELETE FROM operations
                             WHERE operation_id = ?')
            ->execute([$id]);

        return true;
    }

    public function findStatistics (): \Generator
    {
        /**
         * @var OperationDTO $result
         */
        $result = $this->db
            ->query('SELECT name, COUNT(o.operation_id) AS count, SUM(o.sum) AS totalSum
                            FROM reasons r
                            INNER JOIN operations o ON r.reason_id = o.reason_id
                            GROUP BY r.name')
            ->execute()
            ->fetchAll();

        foreach ($result as $row) {
            /**
             * @var StatisticsDTO $stat
             */
            $stat = $this->dataBinder->bind($row, StatisticsDTO::class);
            $stat->setReason($row['name']);
            $stat->setCount($row['count']);
            $stat->setSum($row['totalSum']);

            yield $stat;
        }
    }
}