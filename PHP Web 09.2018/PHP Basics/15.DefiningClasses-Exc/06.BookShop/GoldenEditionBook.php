<?php
spl_autoload_register();

class GoldenEditionBook extends Book
{
    public function __construct(string $title, string $author, float $price)
    {
        parent::__construct($title, $author, $price);
    }

    /**
     * @return float
     */
    public function getPrice(): float
    {
        return parent::getPrice() * 1.3;
    }
}