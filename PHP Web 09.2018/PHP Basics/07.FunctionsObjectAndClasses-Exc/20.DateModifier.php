<?php
class DateModifier {
    private $date1;
    private $date2;
    private $difference;

    /**
     * DateModifier constructor.
     * @param $date1
     * @param $date2
     * @param $difference
     */
    public function __construct($date1, $date2)
    {
        $this->date1 = $date1;
        $this->date2 = $date2;
        $this->setDifference($this->date1, $this->date2);
    }

    /**
     * DateModifier constructor.
     * @param $difference
     */


    public function getDifference()
    {
        return $this->difference;
    }

    public function setDifference(DateTime $date1, DateTime $date2): void
    {
        $this->difference = $date1->diff($date2);
    }
}
list($year, $month, $day) = explode(' ', readline());
$date1 = new DateTime("$year-$month-$day");
list($year, $month, $day) = explode(' ', readline());
$date2 = new DateTime("$year-$month-$day");
$modifier = new DateModifier($date1, $date2);

foreach ($modifier->getDifference() as $key => $item) {
    if ($key == 'days') {
        echo $item;
        break;
    }
}