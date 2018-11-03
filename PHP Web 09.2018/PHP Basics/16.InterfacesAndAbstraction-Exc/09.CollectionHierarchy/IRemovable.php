<?php

interface IRemovable extends IAddable
{
    public function remove(): string;
}