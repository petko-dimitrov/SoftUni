function cook(input) {
    let number = Number(input[0]);

    for (let i = 1; i < input.length; i++) {
        let command = input[i].toString();

        switch (command) {
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number++;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number = number - 0.2 * number;
                break;
            default:
                break;
        }

        console.log(number);
    }
}

cook([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);