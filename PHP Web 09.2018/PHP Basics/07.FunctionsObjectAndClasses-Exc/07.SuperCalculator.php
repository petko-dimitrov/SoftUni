<?php
$command = readline();
$result = [];

while ($command !== 'finally') {
    switch ($command) {
        case 'sum':
            $result[] = sum();
            break;
        case 'multiply':
            $result[] = multiply();
            break;
        case 'divide':
            $result[] = divide();
            break;
        case 'subtract':
            $result[] = subtract();
            break;
        case 'factorial':
            $num = floatval(readline());
            $result[] = factorial($num);
            break;
        case 'root':
            $num = floatval(readline());
            $result[] = root($num);
            break;
        case 'power':
            $num1 = floatval(readline());
            $num2 = floatval(readline());
            $result[] = power($num1, $num2);
            break;
        case 'absolute':
            $num = floatval(readline());
            $result[] = absolute($num);
            break;
        case 'pythagorean':
            $num1 = floatval(readline());
            $num2 = floatval(readline());
            $result[] = pythagorean($num1, $num2);
            break;
        case 'triangleArea':
            $num1 = floatval(readline());
            $num2 = floatval(readline());
            $num3 = floatval(readline());
            $result[] = triangleArea($num1, $num2, $num3);
            break;
        case 'quadratic':
            $num1 = floatval(readline());
            $num2 = floatval(readline());
            $num3 = floatval(readline());
            $result[] = quadratic($num1, $num2, $num3);
            break;
        default:
            break;
    }

    $command = readline();
}

$result = array_filter($result, function ($a) {
    return $a !== '';
});

$command = readline();


function reduceArr($command) {

}
switch ($command) {
    case 'sum':
        $res = array_sum($result);
        $result = [$res];
        break;
    case 'multiply':
        $res = 1;
        foreach ($result as $item) {
            $res *= $item;
        }
        $result = [$res];
        break;
    case 'divide':
        $res = pow($result[0], 2);
        foreach ($result as $item) {
            $res /= $item;
        }
        $result = [$res];
        break;
    case 'subtract':
        $res = 0;
        foreach ($result as $item) {
            $res -= $item;
        }
        $result = [$res];
        break;
    case 'factorial':
        $newArr = [];
        foreach ($result as $item) {
            $newArr[] = factorial($item);
        }
        $result = $newArr;
        break;
    case 'root':
        $newArr = [];
        foreach ($result as $item) {
            $newArr[] = root($item);
        }
        $result = $newArr;
        break;
    case 'power':
        while (count($result) > 2) {
            $newArr = [];
            $count = 0;
            foreach ($result as $item) {
                if ($count % 2 == 0) {
                    $num1 = $item;
                    $newArr[] = $num1;
                } else {
                    $num2 = $item;
                    array_pop($newArr);
                    $newArr[] = power($num1, $num2);
                }
                $count++;
            }
            $result = $newArr;
        }
        break;
    case 'absolute':
        $newArr = [];
        foreach ($result as $item) {
            $newArr[] = absolute($item);
        }
        $result = $newArr;
        break;
    case 'pythagorean':
        while (count($result) > 2) {
            $newArr = [];
            $count = 0;
            foreach ($result as $item) {
                if ($count % 2 == 0) {
                    $num1 = $item;
                    $newArr[] = $num1;
                } else {
                    $num2 = $item;
                    array_pop($newArr);
                    $newArr[] = pythagorean($num1, $num2);
                }
                $count++;
            }
            $result = $newArr;
        }
        break;
    case 'triangleArea':
        while (count($result) > 3) {
            $count = 0;
            $newArr = [];
            foreach ($result as $item) {
                if ($count % 3 == 0) {
                    $num1 = $item;
                    $newArr[] = $num1;
                } else if ($count % 3 == 1) {
                    $num2 = $item;
                    $newArr[] = $num2;
                } else {
                    $num3 = $item;
                    array_pop($newArr);
                    array_pop($newArr);
                    $newArr[] = triangleArea($num1, $num2, $num3);
                }
                $count++;
            }
            $result = $newArr;
        }
        break;
    case 'quadratic':
        while (count($result) > 3) {
            $newArr = [];
            $count = 0;
            foreach ($result as $item) {
                if ($count % 3 == 0) {
                    $num1 = $item;
                    $newArr[] = $num1;
                } else if ($count % 3 == 1) {
                    $num2 = $item;
                    $newArr[] = $num2;
                } else {
                    $num3 = $item;
                    array_pop($newArr);
                    array_pop($newArr);
                    $newArr[] = quadratic($num1, $num2, $num3);
                }
                $count++;
            }
            $result = $newArr;
        }
        break;
    default:
        break;
}

echo implode(', ', $result);

function sum() {
    $num1 = floatval(readline());
    $num2 = floatval(readline());
    return $num1 + $num2;
}

function multiply() {
    $num1 = floatval(readline());
    $num2 = floatval(readline());
    return $num1 * $num2;
}

function divide() {
    $num1 = floatval(readline());
    $num2 = floatval(readline());

    if ($num2 == 0) {
        echo "Caught exception: Division by zero." . PHP_EOL;
        return '';
    }

    return $num1 / $num2;
}

function subtract() {
    $num1 = floatval(readline());
    $num2 = floatval(readline());
    return $num1 - $num2;
}

function factorial($num) {
    $res = 1;

    for ($i = 1; $i <= $num; $i++){
        $res *= $i;
    }

    return $res;
}

function root($num) {
    if ($num < 0) {
        echo "Caught exception: Can't take the root of a negative number" . PHP_EOL;
        return '';
    }

    return sqrt($num);
}

function power ($num1, $num2) {
    return pow($num1, $num2);
}

function absolute($num) {
    return abs($num);
}

function pythagorean($num1, $num2) {
    return sqrt(pow($num1, 2) + pow($num2, 2));
}

function triangleArea($num1, $num2, $num3) {
    $p = ($num1 + $num2 + $num3) / 2;
    $res = sqrt($p * ($p - $num1) * ($p - $num2) * ($p - $num3));

    if ($res == NAN) {
        echo "Caught exception: Can't take the root of a negative number" .PHP_EOL;
        $res = '';
    }
    return $res;
}

function quadratic($num1, $num2, $num3) {
    if ($num1 == 0) {
        echo "Caught exception: Division by zero." .PHP_EOL;
        return '';
    }

    $x1 = (-1 * $num2 + sqrt(pow($num2, 2) - 4*$num1*$num3)) / 2 * $num1;
    $x2 = (-1 * $num2 - sqrt(pow($num2, 2) - 4*$num1*$num3)) / 2 * $num1;

    if (!$x1 && !$x2) {
        return 0;
    } else if (!$x2) {
        return $x1;
    } else {
        return $x1 + $x2;
    }
}