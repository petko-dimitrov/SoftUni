<?php

abstract class Collection
{
    /**
     * @var array
     */
    protected $collection;

    /**
     * AddCollection constructor.
     */
    public function __construct()
    {
        $this->collection = [];
    }
}