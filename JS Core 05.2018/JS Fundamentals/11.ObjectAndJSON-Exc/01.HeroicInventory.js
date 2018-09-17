function solve(arr) {
    let heroes = [];

    for (let hero of arr) {
        let currentHero = hero.split(/\/|,| /g).filter(x => x !== '');
        let obj = {"name": currentHero[0], "level": +currentHero[1]}
        obj["items"] = [];
        for (let i = 2; i < currentHero.length; i++) {
            obj["items"].push(currentHero[i]);
        }
        heroes.push(obj);
    }

    console.log(JSON.stringify(heroes));
}

solve(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']);