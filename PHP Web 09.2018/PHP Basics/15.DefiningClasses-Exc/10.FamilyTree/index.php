<?php
spl_autoload_register();
$person = readline();

if (preg_match('/[0-9]/', $person)) {
    $personBirthday = $person;
} else {
    $personName = $person;
}


$people = [];
$connections = [];
$input = readline();

while ($input !== 'End') {
    if (preg_match('/ - /', $input)) {
        $connections[] = $input;
    } else {
        [$firstName, $lastName, $birthday] = explode(' ', $input);
        $people[] = new Person($firstName, $lastName, $birthday);

        if (isset($personName) && $personName == ($firstName . ' ' . $lastName)) {
            $person = new Person($firstName, $lastName, $birthday);
        } else if (isset($personBirthday) && $personBirthday == $birthday){
            $person = new Person($firstName, $lastName, $birthday);
        }
    }

    $input = readline();
}

$fullName = $person->getFirstName() . ' ' . $person->getLastName();

foreach ($connections as $connection) {
    [$parent, $child] = explode(' - ', $connection);

    if ($parent == $fullName || $parent == $person->getBirthday()) {
        $person->searchConnection($people, 'child', $child);
    } else if ($child == $fullName || $child == $person->getBirthday()) {
        $person->searchConnection($people, 'parent', $parent);
    }
}

echo $person;