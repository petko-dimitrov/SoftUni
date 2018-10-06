<?php
class Person {
    /**
     * @var string
     */
    private $name;
    /**
     * @var Company
     */
    private $company;
    /**
     * @var Car
     */
    private $car;
    /**
     * @var array
     */
    private $pokemons;
    /**
     * @var array
     */
    private $parents;
    /**
     * @var array
     */
    private $children;

    /**
     * Person constructor.
     * @param $name
     */
    public function __construct(string $name)
    {
        $this->setName($name);
        $this->pokemons = [];
        $this->parents = [];
        $this->children = [];
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return Company
     */
    public function getCompany(): Company
    {
        return $this->company;
    }

    /**
     * @param Company $company
     */
    public function setCompany(Company $company): void
    {
        $this->company = $company;
    }

    /**
     * @return mixed
     */
    public function getCar()
    {
        return $this->car;
    }

    /**
     * @param mixed $car
     */
    public function setCar($car): void
    {
        $this->car = $car;
    }

    /**
     * @return array
     */
    public function getPokemons(): array
    {
        return $this->pokemons;
    }

    /**
     * @param Pokemon $pokemon
     */
    public function addPokemon(Pokemon $pokemon): void
    {
        $this->pokemons[] = $pokemon;
    }

    /**
     * @return array
     */
    public function getParents(): array
    {
        return $this->parents;
    }

    /**
     * @param RelativePerson $parent
     */
    public function addParent(RelativePerson $parent): void
    {
        $this->parents[] = $parent;
    }

    /**
     * @return array
     */
    public function getChildren(): array
    {
        return $this->children;
    }

    /**
     * @param RelativePerson $children
     */
    public function addChild(RelativePerson $child): void
    {
        $this->children[] = $child;
    }

    public function __toString()
    {
        $result = $this->name . PHP_EOL;
        $result .= "Company:" . PHP_EOL;
        if (isset($this->company)) {
            $result .= $this->company . PHP_EOL;
        }
        $result .= "Car:" . PHP_EOL;
        if (isset($this->car)) {
            $result .= $this->car . PHP_EOL;
        }
        $result .= "Pokemon:" . PHP_EOL;
        foreach ($this->pokemons as $pokemon) {
            $result .= $pokemon . PHP_EOL;
        }
        $result .= "Parents:" . PHP_EOL;
        foreach ($this->parents as $parent) {
            $result .= $parent . PHP_EOL;
        }
        $result .= "Children:" . PHP_EOL;
        foreach ($this->children as $child) {
            $result .= $child . PHP_EOL;
        }
        return $result;
    }
}

class Company {
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $department;
    /**
     * @var float
     */
    private $salary;

    /**
     * Company constructor.
     * @param string $name
     * @param string $department
     * @param float $salary
     */
    public function __construct(string $name, string $department, float $salary)
    {
        $this->setName($name);
        $this->setDepartment($department);
        $this->setSalary($salary);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    private function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getDepartment(): string
    {
        return $this->department;
    }

    /**
     * @param string $department
     */
    private function setDepartment(string $department): void
    {
        $this->department = $department;
    }

    /**
     * @return float
     */
    public function getSalary(): float
    {
        return $this->salary;
    }

    /**
     * @param float $salary
     */
    private function setSalary(float $salary): void
    {
        $this->salary = $salary;
    }

    public function __toString()
    {
        $salary = number_format($this->salary, 2, '.', '');
        return "$this->name $this->department $salary";
    }
}

class Car {
    /**
     * @var string
     */
    private $model;
    /**
     * @var float
     */
    private $speed;

    /**
     * Car constructor.
     * @param string $model
     * @param float $speed
     */
    public function __construct(string $model, float $speed)
    {
        $this->setModel($model);
        $this->setSpeed($speed);
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @param string $model
     */
    private function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * @return float
     */
    public function getSpeed(): float
    {
        return $this->speed;
    }

    /**
     * @param float $speed
     */
    private function setSpeed(float $speed): void
    {
        $this->speed = $speed;
    }

    public function __toString()
    {
        return "$this->model $this->speed";
    }
}

class Pokemon {
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $type;

    /**
     * Pokemon constructor.
     * @param string $name
     * @param string $type
     */
    public function __construct(string $name, string $type)
    {
        $this->setName($name);
        $this->setType($type);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    private function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getType(): string
    {
        return $this->type;
    }

    /**
     * @param string $type
     */
    private function setType(string $type): void
    {
        $this->type = $type;
    }

    public function __toString()
    {
        return "$this->name $this->type";
    }
}

class RelativePerson {
    /**
     * @var string
     */
    private $name;
    /**
     * @var string
     */
    private $birthday;

    /**
     * ParentPerson constructor.
     * @param string $name
     * @param string $birthday
     */
    public function __construct(string $name, string $birthday)
    {
        $this->setName($name);
        $this->setBirthday($birthday);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    private function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getBirthday(): string
    {
        return $this->birthday;
    }

    /**
     * @param string $birthday
     */
    private function setBirthday(string $birthday): void
    {
        $this->birthday = $birthday;
    }

    public function __toString()
    {
        return "$this->name $this->birthday";
    }
}

$people = [];
$input = explode(' ', readline());

while ($input[0] !== 'End') {
    $name = $input[0];

    if (!array_key_exists($name, $people)) {
        $people[$name] = new Person($name);
    }

    switch ($input[1]) {
        case 'company':
            $company = new Company($input[2], $input[3], floatval($input[4]));
            $people[$name]->setCompany($company);
            break;
        case 'pokemon':
            $pokemon = new Pokemon($input[2], $input[3]);
            $people[$name]->addPokemon($pokemon);
            break;
        case 'parents':
            $parent = new RelativePerson($input[2], $input[3]);
            $people[$name]->addParent($parent);
            break;
        case 'children':
            $child = new RelativePerson($input[2], $input[3]);
            $people[$name]->addChild($child);
            break;
        case 'car':
            $car = new Car($input[2], floatval($input[3]));
            $people[$name]->setCar($car);
            break;
        default:
            break;
    }

    $input = explode(' ', readline());
}

$input = readline();
echo $people[$input];