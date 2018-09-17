let result = (function(){
    const Values = [ '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const Suits = {
        CLUBS: '\u2663',
        HEARTS: '\u2665',
        DIAMONDS: '\u2666',
        SPADES: '\u2660'
    };

    class Card {
        constructor(value, suit){
            this.face = value;
            this.suit = suit;
        }

        get face() {
            return this._face;
        }

        get suit() {
            return this._suit;
        }

        set face(val) {
            if (!Values.includes(val)) {
                throw new Error('Invalid value!')
            }
            return this._face = val;
        }

        set suit(s) {
            if (!Object.values(Suits).includes(s)) {
                throw new Error('Invalid suit!')
            }
            return this._suit = s;
        }

        toString() {
            return `${this.face}${this.suit}`;
        }
    }

    return {
        Suits:Suits,
        Card:Card
    }
}());

let Card = result.Card;
let Suits = result.Suits;
let card = new Card('2', Suits.SPADES);
console.log(card.toString());