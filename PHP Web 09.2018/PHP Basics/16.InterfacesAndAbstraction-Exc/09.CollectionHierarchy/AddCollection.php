<?php

class AddCollection extends Collection implements IAddable
{
    public function add($element): int
    {
        array_push($this->collection, $element);
        $count = count($this->collection) - 1;
        return $count;
    }
}