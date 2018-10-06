<?php
class Person {
    public $name;
    public $age;

    public function __construct(string $name, int $age) {
        $this->name = $name;
        $this->age = $age;
    }
}

$n = intval(readline());
$people = [];

for ($i = 0; $i < $n; $i++){
    $input = explode(' ', readline());
    $name = $input[0];
    $age = intval($input[1]);

    array_push($people, new Person($name, $age));
}

$people = array_filter($people, function ($a) {
    return $a->age > 30;
});

usort($people, function (Person $a, Person $b) {
    return $a->name <=> $b->name;
    //return strcmp($a->name, $b->name);
});

foreach ($people as $person) {
    echo "$person->name - $person->age" . PHP_EOL;
}

