<?php

class MoodFactory
{
    public static function getMood(int $happiness): string {
        if ($happiness < -5) {
            return 'Angry';
        } else if ($happiness < 0) {
            return 'Sad';
        } else if ($happiness < 15) {
            return 'Happy';
        } else {
            return 'PHP';
        }
    }
}