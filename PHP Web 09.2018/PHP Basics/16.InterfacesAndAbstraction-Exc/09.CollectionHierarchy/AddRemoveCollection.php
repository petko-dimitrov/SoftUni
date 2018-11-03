<?php

class AddRemoveCollection extends Collection implements IRemovable
{
    public function add($element): int
    {
        array_unshift($this->collection, $element);
        return 0;
    }

    public function remove(): string
    {
        return array_pop($this->collection);
    }
}