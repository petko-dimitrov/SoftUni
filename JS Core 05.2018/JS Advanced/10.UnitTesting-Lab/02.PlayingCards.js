function solve(value, suit) {
    const VALUES = [ '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const SUITS = {
        C: '\u2663',
        H: '\u2665',
        D: '\u2666',
        S: '\u2660'
    };

    if (!VALUES.includes(value)) {
        throw new Error('Invalid value');
    }
    if (!SUITS.hasOwnProperty(suit)) {
        throw new Error('Invalid suit');
    }

    return {
        value: value,
        suit: SUITS[suit],
        toString: function () {
            return this.value + this.suit;
        }
    }
}

console.log('' + solve('A', 'S'));
console.log('' + solve('1', 'C'));