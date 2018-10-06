<?php

class Employee
{
    public $name;
    public $salary;
    public $position;
    public $department;
    public $email;
    public $age;

    function __construct($name, $salary, $position, $department, $email = 'n/a', $age = -1)
    {
        $this->name = $name;
        $this->salary = $salary;
        $this->position = $position;
        $this->department = $department;
        $this->email = $email;
        $this->age = $age;
    }

    public function __toString()
    {
        $sal = number_format($this->salary, 2, '.', '');
        return "$this->name $sal $this->email $this->age";
    }
}

class Department
{
    private $name;
    private $employees;

    public function __construct(string $name)
    {
        $this->name = $name;
        $this->employees = [];
    }

    public function getName(): string
    {
        return $this->name;
    }

    public function getEmployees(): array
    {
        return $this->employees;
    }

    public function getAvgSalary(): float
    {
        $sum = 0;
        foreach ($this->employees as $employee) {
            $sum += $employee->salary;
        }
        return $sum / count($this->employees);
    }

    public function addEmployee(Employee $employee)
    {
        $this->employees[] = $employee;
    }
}

$n = intval(readline());
$departments = [];

for ($i = 0; $i < $n; $i++) {
    $input = explode(' ', readline());

    if (count($input) === 4) {
        list($name, $salary, $position, $department) = $input;
        $employee = new Employee($name, floatval($salary), $position, $department);
    } else if (count($input) === 5) {
        if (is_numeric($input[4])) {
            list($name, $salary, $position, $department, $age) = $input;
            $employee = new Employee($name, $salary, $position, $department, 'n/a', $age);
        } else {
            list($name, $salary, $position, $department, $email) = $input;
            $employee = new Employee($name, $salary, $position, $department, $email);
        }
    } else {
        list($name, $salary, $position, $department, $email, $age) = $input;
        $employee = new Employee($name, floatval($salary), $position, $department, $email, intval($age));
    }

    if (!array_key_exists($department, $departments)) {
        $dep = new Department($department);
        $departments[$department] = $dep;
    }

    $departments[$department]->addEmployee($employee);
}

usort($departments, function (Department $a, Department $b) {
    return $b->getAvgSalary() <=> $a->getAvgSalary();
});

$bestDepartment = $departments[0]->getEmployees();

usort($bestDepartment, function (Employee $a, Employee $b) {
    return $b->salary <=> $a->salary;
});

echo "Highest Average Salary: " . $departments[0]->getName() . PHP_EOL;

foreach ($bestDepartment as $employee) {
    echo $employee . PHP_EOL;
}