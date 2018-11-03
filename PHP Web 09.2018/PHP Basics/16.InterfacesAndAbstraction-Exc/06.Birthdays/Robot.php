<?php

class Robot implements IIdentity
{
    /**
     * @var string
     */
    private $model;
    /**
     * @var string
     */
    private $id;

    public function __construct(string $model, string $id)
    {
        $this->setModel($model);
        $this->setId($id);
    }

    private function setModel($model): void {
        $this->model = $model;
    }

    public function setId($id): void
    {
        $this->id = $id;
    }
}