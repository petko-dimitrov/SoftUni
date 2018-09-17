function solve(arr) {
    let cards = [];

    for (const card of arr) {
        let value = card.slice(0, card.length - 1);
        let suit = card[card.length - 1];

        try {
            let currentCard = makeCard(value, suit);
            cards.push(currentCard);
        } catch (e) {
            console.log(`Invalid card: ${card}`);
            return;
        }
    }

    console.log(cards.join(' '));

    function makeCard(value, suit) {
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
}

solve(['AS', '10D', 'KH', '2C']);
solve(['5S', '3D', 'QD', '1C']);