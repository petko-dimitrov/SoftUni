function findPrice(input) {
    let movie = input[0].toLowerCase();
    let day = input[1].toLowerCase();

    let days = ['monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', 'sunday'];
    let movies = ['the godfather', 'schindler\'s list', 'casablanca', 'the wizard of oz'];

    if (!days.includes(day) || !movies.includes(movie)) {
        console.log("error");
        return;
    }

    let price = 0;

    if (movie === 'the godfather') {
        switch (day) {
            case 'monday':
                price = 12;
                break;
            case 'tuesday':
                price = 10;
                break;
            case 'wednesday':
            case 'friday':
                price = 15;
                break;
            case 'thursday':
                price = 12.5;
                break;
            case 'saturday':
                price = 25;
                break;
            case 'sunday':
                price = 30;
                break;
            default:
                break;
        }
    } else if (movie === 'schindler\'s list') {
        switch (day) {
            case 'monday':
            case 'tuesday':
            case 'wednesday':
            case 'thursday':
            case 'friday':
                price = 8.5;
                break;
            case 'saturday':
            case 'sunday':
                price = 15;
                break;
            default:
                break;
        }
    } else if (movie === 'casablanca') {
        switch (day) {
            case 'monday':
            case 'tuesday':
            case 'wednesday':
            case 'thursday':
            case 'friday':
                price = 8;
                break;
            case 'saturday':
            case 'sunday':
                price = 10;
                break;
            default:
                break;
        }
    } else {
        switch (day) {
            case 'monday':
            case 'tuesday':
            case 'wednesday':
            case 'thursday':
            case 'friday':
                price = 10;
                break;
            case 'saturday':
            case 'sunday':
                price = 15;
                break;
            default:
                break;
        }
    }

    if (price !== 0) {
        console.log(price);
    }
}

findPrice(['Casablanca', 'Monday']);