function solve() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError('Abstract class cannot be instantiated directly');
            }

            this.weight = weight;
            this.melonSort = melonSort;
            this.element = '';
            this._elementIndex = this.weight * this.melonSort.length;
        }

        get elementIndex () {
            return this._elementIndex;
        }

        set elementIndex(v) {
            this._elementIndex = v;
        }

        toString () {
            return `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
        }
    }

    class Watermelon extends Melon{
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = this.constructor.name.slice(0, -5);
        }
    }

    class Firemelon extends Melon{
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = this.constructor.name.slice(0, -5);
        }
    }

    class Earthmelon extends Melon{
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = this.constructor.name.slice(0, -5);
        }
    }

    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = this.constructor.name.slice(0, -5);
        }
    }

    class Melolemonmelon extends Airmelon{
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.elements = ['Fire', 'Earth', 'Air', 'Water'];
            this.element = 'Water';
        }

        morph() {
            let el = this.elements.shift();
            this.element = el;
            this.elements.push(el);
        }
    }

    return{Melon, Watermelon, Earthmelon, Firemelon, Airmelon, Melolemonmelon};
}