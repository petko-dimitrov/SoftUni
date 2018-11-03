<?php

spl_autoload_register();
$input = explode(' ', readline());
$soldiers = [];

while ($input[0] !== 'End') {
    $type = $input[0];
    $id = $input[1];
    $firstName = $input[2];
    $lastName = $input[3];

    if ($type === 'Spy') {
        $codeNumber = $input[4];
        $soldiers[$id] = new $type($id, $firstName, $lastName, $codeNumber);
    } else {
        $salary = floatval($input[4]);

        switch ($type) {
            case 'Private':
                $soldiers[$id] = new PrivateSoldier($id, $firstName, $lastName, $salary);
                break;
            case 'LeutenantGeneral':
                $soldier = new $type($id, $firstName, $lastName, $salary);
                for ($i = 5; $i < count($input); $i++) {
                    $privateId = $input[$i];
                    $soldier->addPrivate($soldiers[$privateId]);
                }
                $soldiers[$id] = $soldier;
                break;
            case 'Engineer':
            case 'Commando':
                $corps = $input[5];
                $soldier = new $type($id, $firstName, $lastName, $salary, $corps);
                for ($i = 6; $i < count($input) - 1; $i+=2){
                    $name = $input[$i];
                    $value = $input[$i+1];
                    if ($type === 'Engineer') {
                        $repair = new Repair($name, intval($value));
                        $soldier->addRepair($repair);
                    } else {
                        try {
                            $mission = new Mission($name, $value);
                            $soldier->addMission($mission);
                        } catch (Exception $e) {

                        }
                    }
                }
            $soldiers[$id] = $soldier;
            break;
            default:
                break;
        }
    }

    $input = explode(' ', readline());
}

foreach ($soldiers as $soldier) {
    echo $soldier . PHP_EOL;
}