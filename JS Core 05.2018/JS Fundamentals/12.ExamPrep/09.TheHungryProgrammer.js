function solve(meals, commands) {
    let mealsEaten = 0;

    for (let line of commands) {
        let command = line.split(' ')[0];

        switch (command) {
            case 'Serve':
                if (meals.length > 0) {
                    console.log(`${meals.pop()} served!`);
                }
            break;
            case 'Add':
                if (line.split(' ').length === 2) {
                    let mealToAdd = line.split(' ')[1];
                    meals.unshift(mealToAdd);
                }
                break;
            case 'Shift':
                if (line.split(' ').length === 3) {
                    let first = Number(line.split(' ')[1]);
                    let second = Number(line.split(' ')[2]);
                    if (first >= 0 && first < meals.length && second >= 0 && second < meals.length && first !== second) {
                        let temp = meals[first];
                        meals[first] = meals[second];
                        meals[second] = temp;
                    }
                }
                break;
            case 'Eat':
                if (meals.length > 0) {
                    console.log(`${meals.shift()} eaten`);
                    mealsEaten++;
                }
                break;
            case 'Consume':
                if (line.split(' ').length === 3) {
                    let start = Number(line.split(' ')[1]);
                    let end = Number(line.split(' ')[2]);
                    if (start >= 0 && start < meals.length && end > 0 && end < meals.length && start < end) {
                        console.log("Burp!");
                        mealsEaten += end - start + 1;
                        meals.splice(start, end - start + 1);
                    }
                }
                break;
            case 'End':
                if (meals.length > 0) {
                    console.log(`Meals left: ${meals.join(', ')}`);
                } else {
                    console.log('The food is gone');
                }
                console.log(`Meals eaten: ${mealsEaten}`);
                return;
            default:
                break;
        }
    }
}

solve(['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],
    ['Add spaghetti',
        'Shift 0 1',
        'Consume 1 4',
        'End']);