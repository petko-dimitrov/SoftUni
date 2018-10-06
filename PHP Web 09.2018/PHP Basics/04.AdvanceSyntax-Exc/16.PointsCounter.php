<?php
$input = explode('|', readline());
$teams = [];

while($input[0] != 'Result') {
    $input[0] = str_replace(['@', '%', '&', '$', '*'], '', $input[0]);
    $input[1] = str_replace(['@', '%', '&', '$', '*'], '', $input[1]);
    $points = intval($input[2]);

    if (ctype_upper($input[0])) {
        $team = $input[0];
        $player = $input[1];
    } else {
        $team = $input[1];
        $player = $input[0];
    }

    if (!array_key_exists($team, $teams)) {
        $teams[$team] = [];
    }

    $teams[$team][$player] = $points;

    $input = explode('|', readline());
}

$teamsTotal = [];
$teamsBestPlayer = [];

foreach ($teams as $teamName => $team) {
    $totalPoints = 0;
    $mostPoints = 0;
    $bestPlayer = '';

    foreach ($team as $key => $value) {
        $totalPoints += $value;

        if ($value > $mostPoints) {
            $mostPoints = $value;
            $bestPlayer = $key;
        }
    }

    $teamsTotal[$teamName] = $totalPoints;
    $teamsBestPlayer[$teamName] = $bestPlayer;
}

arsort($teamsTotal);

foreach ($teamsTotal as $team => $total) {
    echo "$team => $total" . PHP_EOL . "Most points scored by $teamsBestPlayer[$team]" . PHP_EOL;
}
