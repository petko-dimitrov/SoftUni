function solve(commands) {
    let inventory = commands[0].split(' ');

    for (let i = 1; i < commands.length - 1; i++) {
        let command = commands[i].split(' ').shift();
        let item = commands[i].split(' ').pop();

        switch (command) {
            case 'Buy':
                if (!inventory.includes(item)) {
                    inventory.push(item);
                }
                break;
            case 'Trash':
                if (inventory.includes(item)) {
                    let index = inventory.indexOf(item);
                    inventory.splice(index, 1);
                }
                break;
            case 'Repair':
                if (inventory.includes(item)) {
                    let index = inventory.indexOf(item);
                    inventory.splice(index, 1);
                    inventory.push(item);
                }
                break;
            case 'Upgrade':
                let itemToUpgrade = item.split('-').shift();
                if (inventory.includes(itemToUpgrade)) {
                    item = item.replace('-', ':');
                    let index = inventory.indexOf(itemToUpgrade);
                    inventory.splice(index + 1, 0, item);
                }
                break;
            default:
                break;
        }
    }

    console.log(inventory.join(' '));
}

solve(['SWORD Shield Spear', 'Buy Bag', 'Trash Shield',
    'Repair Spear', 'Upgrade SWORD-Steel', 'Fight!']);