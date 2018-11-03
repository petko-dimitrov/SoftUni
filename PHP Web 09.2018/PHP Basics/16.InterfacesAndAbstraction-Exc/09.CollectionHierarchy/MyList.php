<?php

class MyList extends AddRemoveCollection implements IRemovable
{
    /**
     * @var int
     */
    private $used;

    /**
     * @return int
     */
    public function getUsed(): int
    {
        return $this->used;
    }

    public function add($element): int
    {
        $this->used++;
        array_unshift($this->collection, $element);
        return 0;
    }

    public function remove(): string
    {
        $this->used--;
        return array_shift($this->collection);
    }
}