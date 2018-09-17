function checkSpeed(input) {
    let speed = input[0];
    let area = input[1];
    let difference = 0;

    switch (area) {
        case 'motorway':
            difference = speed - 130;
            break;
        case 'interstate':
            difference = speed - 90;
            break;
        case 'city':
            difference = speed - 50;
            break;
        case 'residential':
            difference = speed - 20;
            break;
        default:
            break;
    }

    if (difference > 40) {
        console.log('reckless driving');
    } else if (difference > 20) {
        console.log('excessive speeding');
    } else if (difference > 0) {
        console.log('speeding');
    }
}

checkSpeed([200, 'motorway']);