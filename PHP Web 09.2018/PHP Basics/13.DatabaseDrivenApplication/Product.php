<?php
/**
 * Created by PhpStorm.
 * User: petko
 * Date: 10/12/2018
 * Time: 3:23 PM
 */

class Product
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

    public function getAll($from_record_num, $records_per_page) {
        $result = $this->db->query("SELECT p.id, p.name, p.price, p.created, c.name AS cname
                                            FROM products p
                                            JOIN categories c ON p.category_id = c.id
                                            ORDER BY p.id
                                            LIMIT $from_record_num, $records_per_page");

        while ($row = $result->fetch(PDO::FETCH_ASSOC)) {
            yield $row;
        }
    }

    // used for paging products
    public function countAll() : int {
        return  $this->db->query("SELECT count(*)
                                            FROM products")->fetchColumn();
    }

    public function getOne($id) {
        $result = $this->db->prepare('SELECT p.id, p.name, p.price, p.description, p.created, p.modified, c.id AS cid, c.name AS cname
                                                FROM products p
                                                JOIN categories c ON p.category_id = c.id
                                                WHERE p.id = :id');
        $result->bindParam('id', $id);
        $result->execute();

        return $result->fetch(PDO::FETCH_ASSOC);
    }

    public function createProduct ($name, $price, $description, $cat_id) {
        $result = $this->db->prepare('INSERT INTO products (name, price, description, category_id)
                                                  VALUES (:name, :price, :description, :cat_id)');
        $result->bindParam('name',$name);
        $result->bindParam('price',$price);
        $result->bindParam('description',$description);
        $result->bindParam('cat_id',$cat_id);

        $result->execute();
    }

    public function editProduct ($id, $name, $price, $description, $cat_id) {
        $result = $this->db->prepare('UPDATE products 
                                              SET name = :name, price = :price, 
                                               description = :description, category_id = :cat_id
                                                WHERE id = :id');

        $result->bindParam('name',$name);
        $result->bindParam('price',$price);
        $result->bindParam('description',$description);
        $result->bindParam('cat_id',$cat_id);
        $result->bindParam('id',$id);

        $result->execute();
    }

    public function deleteProduct ($id) {
        $result = $this->db->prepare('DELETE FROM products
                                              WHERE id = :id');
        $result->bindParam('id',$id);
        $result->execute();
    }
}