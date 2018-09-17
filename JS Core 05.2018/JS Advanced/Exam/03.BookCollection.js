class BookCollection {
    constructor(shelfGenre, room, shelfCapacity) {
        this.room = room;

        if (this.room !== 'livingRoom' && this.room !== 'bedRoom' && this.room !== 'closet') {
            throw new Error(`Cannot have book shelf in ${this.room}`);
        }

        this.shelfGenre = shelfGenre;
        this.shelf = [];
        this.shelfCapacity = shelfCapacity;
    }

    addBook(bookName, bookAuthor, genre) {
        if (this.shelf.length === this.shelfCapacity) {
            this.shelf.shift();
        }

        if (genre) {
            this.shelf.push({'bookName': bookName, 'bookAuthor': bookAuthor, 'genre': genre});
        } else {
            this.shelf.push({'bookName': bookName, 'bookAuthor': bookAuthor});
        }

        this.orderBy();
        return this;
    }

    orderBy() {
        this.shelf.sort((a, b) => {
            return a.bookAuthor.localeCompare(b.bookAuthor);
        });
    }

    throwAwayBook(bookName) {
        let matchFound = true;

        while (matchFound) {
            let index;

            for (let i = 0; i < this.shelf.length; i++) {
                if (this.shelf[i].bookName === bookName) {
                    index = i;
                    break;
                }
            }

            if (index !== undefined) {
                this.shelf.splice(index, 1);
            } else {
                matchFound = false;
            }
        }
    }

    showBooks(genre) {
        let bookFound = false;
        let result = `Results for search "${genre}":\n`;
        for (const book of this.shelf) {
            if (book.genre) {
                if (book.genre.toLowerCase() === genre.toLowerCase()) {
                    result += `\uD83D\uDCD6 ${book.bookAuthor} - "${book.bookName}"\n`;
                    bookFound = true;
                }
            }
        }

        if (bookFound) {
            return result.trim();
        } else {
            return '';
        }
    }

    get shelfCondition() {
        return this.shelfCapacity - this.shelf.length;
    }

    toString() {
        if (this.shelf.length === 0) {
            return "It's an empty shelf";
        }

        let result = `"${this.shelfGenre}" shelf in ${this.room} contains:\n`;

        for (const book of this.shelf) {
            result += `\uD83D\uDCD6 "${book.bookName}" - ${book.bookAuthor}\n`;
        }

        return result.trim();
    }
}

let livingRoom = new BookCollection("Programming", "livingRoom", 5)
    .addBook("Introduction to Programming with C#", "Svetlin Nakov")
    .addBook("Introduction to Programming with Java", "Svetlin Nakov")
    .addBook("Programming for .NET Framework", "Svetlin Nakov");