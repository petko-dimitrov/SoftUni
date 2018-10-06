<?php
class Person {
    public $name;
    public $age;
    public $occupation;

    function __construct(string $name, int $age, string $occupation) {
        $this->name = $name;
        $this->age = $age;
        $this->occupation = $occupation;
    }

    function __toString()
    {
        return "$this->name - age: $this->age, occupation: $this->occupation";
    }
}

$people = [];
$input = readline();

while($input !== 'END') {
    list($name, $age, $occupation) = explode(' ', $input);
    $person = new Person($name, (int)$age, $occupation);
    $people[] = $person;
    $input = readline();
}

usort($people, function ($a, $b) {
    return $a->age <=> $b->age;
});

foreach ($people as $person) {
    echo $person . PHP_EOL;
}