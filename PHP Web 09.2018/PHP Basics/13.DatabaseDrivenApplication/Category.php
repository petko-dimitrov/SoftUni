<?php

class Category
{
    /**
     * @var PDO
     */
    private $db;

    /**
     * Product constructor.
     * @param PDO $db
     */
    public function __construct(PDO $db)
    {
        $this->db = $db;
    }

    public function getAll() {
        $result = $this->db->query('SELECT id, name FROM categories');

        while ($row = $result->fetch(PDO::FETCH_ASSOC)){
            yield $row;
        }
    }
}