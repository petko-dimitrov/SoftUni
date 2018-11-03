<?php
class Song
{
    /**
     * @var string
     */
    private $artist;
    /**
     * @var string
     */
    private $title;
    /**
     * @var int
     */
    private $minutes;
    /**
     * @var string
     */
    private $length;
    /**
     * @var int
     */
    private $seconds;

    /**
     * Song constructor.
     * @param string $artist
     * @param string $title
     * @param string $length
     * @throws InvalidSongNameException
     * @throws InvalidArtistNameException
     * @throws InvalidSongException
     */
    public function __construct(string $artist, string $title, string $length)
    {
        $this->setArtist($artist);
        $this->setTitle($title);
        $this->setLength($length);
    }

    /**
     * @return string
     */
    public function getArtist(): string
    {
        return $this->artist;
    }

    /**
     * @param string $artist
     * @throws InvalidArtistNameException
     * @throws InvalidSongException
     */
    private function setArtist(string $artist): void
    {
        if ($artist == '') {
            throw new InvalidSongException();
        }
        if (strlen($artist) < 3 || strlen($artist) > 20) {
            throw new InvalidArtistNameException();
        }
        $this->artist = $artist;
    }


    /**
     * @return string
     */
    public function getTitle(): string
    {
        return $this->title;
    }

    /**
     * @param string $title
     * @throws InvalidSongNameException
     * @throws InvalidSongException
     */
    private function setTitle(string $title): void
    {
        if ($title == '') {
            throw new InvalidSongException();
        }
        if (strlen($title) < 3 || strlen($title) > 20) {
            throw new InvalidSongNameException();
        }
        $this->title = $title;
    }

    /**
     * @return string
     */
    public function getLength(): string
    {
        return $this->length;
    }

    /**
     * @param string $length
     * @throws InvalidSongException
     */
    public function setLength(string $length): void
    {
        list($minutes, $seconds) = array_map('intval', explode(':', $length));
        if ($minutes >= 15) {
            throw new InvalidSongLengthException();
        }
//        if ($minutes <= 0 && $seconds <= 0) {
//            throw new InvalidSongLengthException();
//        }
        if ($minutes < 0 || $minutes > 14) {
            throw new InvalidSongMinutesException();
        }
        if ($seconds < 0 || $seconds > 59) {
            throw new InvalidSongSecondsException();
        }
        $this->minutes = $minutes;
        $this->seconds = $seconds;
        $this->length = $length;
    }

    /**
     * @return int
     */
    public function getMinutes(): int
    {
        return $this->minutes;
    }

    /**
     * @return int
     */
    public function getSeconds(): int
    {
        return $this->seconds;
    }
}