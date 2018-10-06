<?php
$users = [];
$input = explode(' -> ', readline());

while($input[0] !== 'login') {
    $user = $input[0];
    $password = $input[1];
    $users[$user] = $password;
    $input = explode(' -> ', readline());
}

$input = explode(' -> ', readline());
$failures = 0;

while ($input[0] !== 'end') {
    $user = $input[0];
    $password = $input[1];

    if (array_key_exists($user, $users) && $users[$user] === $password) {
        echo "$user: logged in successfully" . PHP_EOL;
    } else {
        echo "$user: login failed" . PHP_EOL;
        $failures++;
    }

    $input = explode(' -> ', readline());
}

echo "unsuccessful login attempts: $failures";