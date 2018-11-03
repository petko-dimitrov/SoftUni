<?php

class FoodFactory
{
    public static function getFoodPoints (string $food): int {
        switch ($food) {
            case 'cram': return 2;
            case 'lembas': return 3;
            case 'apple':
            case 'melon': return 1;
            case 'honeycake': return 5;
            case 'mushrooms': return -10;
            default: return -1;
        }
    }
}