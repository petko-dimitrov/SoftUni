<?php

namespace Database;


class PDOPreparedStatement implements PreparedStatementInterface
{

    /**
     * @var \PDOStatement
     */
    private $pdoStatement;

    /**
     * PDOPreparedStatement constructor.
     * @param bool|\PDOStatement $statement
     */
    public function __construct(\PDOStatement $statement)
    {
        $this->pdoStatement = $statement;
    }

    public function execute(array $params = []): ResultSetInterface
    {
        $this->pdoStatement->execute($params);

        return new PDOResultSet($this->pdoStatement);
    }
}