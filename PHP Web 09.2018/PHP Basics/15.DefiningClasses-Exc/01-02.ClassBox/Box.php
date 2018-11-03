<?php
class Box
{
    /**
     * @var float
     */
    private $length;
    /**
     * @var float
     */
    private $width;
    /**
     * @var float
     */
    private $height;

    /**
     * Box constructor.
     * @param float $length
     * @param float $width
     * @param float $height
     */
    public function __construct(float $length, float $width, float $height)
    {
        $this->setLength($length);
        $this->setWidth($width);
        $this->setHeight($height);
    }

    /**
     * @return float
     */
    public function getLength(): float
    {
        return $this->length;
    }

    /**
     * @param float $length
     * @throws Exception
     */
    private function setLength(float $length): void
    {
        if ($length <= 0) {
            throw new Exception('Length cannot be zero or negative.');
        }
        $this->length = $length;
    }

    /**
     * @return float
     */
    public function getWidth(): float
    {
        return $this->width;
    }

    /**
     * @param float $width
     * @throws Exception
     */
    private function setWidth(float $width): void
    {
        if ($width <= 0) {
            throw new Exception('Width cannot be zero or negative.');
        }
        $this->width = $width;
    }

    /**
     * @return float
     */
    public function getHeight(): float
    {
        return $this->height;
    }

    /**
     * @param float $height
     * @throws Exception
     */
    private function setHeight(float $height): void
    {
        if ($height <= 0) {
            throw new Exception('Height cannot be zero or negative.');
        }
        $this->height = $height;
    }

    public function calcArea () {
        return 2 * $this->length * $this->width + 2 * $this->length * $this->height
            + 2 * $this->width * $this->height;
    }

    public function calcLateralArea () {
        return 2 * $this->length * $this->height + 2 * $this->width * $this->height;
    }

    public function calcVolume () {
        return $this->length * $this->width * $this->height;
    }
}