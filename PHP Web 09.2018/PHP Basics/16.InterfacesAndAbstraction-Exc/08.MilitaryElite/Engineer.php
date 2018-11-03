<?php

class Engineer extends SpecialisedSoldier implements IEngineer
{
    /**
     * @var Repair[]
     */
    private $repairs;

    public function __construct(string $id, string $firstName, string $lastName, float $salary, string $corps)
    {
        parent::__construct($id, $firstName, $lastName, $salary, $corps);
        $this->repairs = [];
    }

    public function addRepair(Repair $repair): void {
        $this->repairs[] = $repair;
    }

   public function __toString()
   {
       $result = parent::__toString() . "Repairs:";
       foreach ($this->repairs as $repair) {
           $result .= PHP_EOL . "  Part Name: {$repair->getPartName()} Hours Worked: {$repair->getHoursWorked()}";
       }
       return $result;
   }
}