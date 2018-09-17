(function solve() {
    String.prototype.ensureStart = function (str) {
        let oldStr = this.valueOf();

        if (this.indexOf(str) !== 0) {
            oldStr = str + oldStr;
        }

        return oldStr;
    };

    String.prototype.ensureEnd = function (str) {
        let oldStr = this.valueOf();
        console.log(this.indexOf(str));

        if (this.indexOf(str) < 0) {
            oldStr = oldStr + str;
        } else if (this.indexOf(str) !== this.length - str.length) {
            oldStr = oldStr + str;
        }

        return oldStr;
    };

    String.prototype.isEmpty = function () {
        return this.length <= 0;
    };

    String.prototype.truncate = function (n) {
        let oldStr = this.valueOf();

        if (this.length <= n) {
            return oldStr;
        }

        oldStr = oldStr.slice(0, n).trim();

        if (this.indexOf(' ') > 0) {
            let words = oldStr.split(' ');
            words[words.length - 2] += '...';
            oldStr = '';

            for (let i = 0; i < words.length - 1; i++) {
                oldStr += `${words[i]} `;
            }

            oldStr = oldStr.slice(0, oldStr.length - 1);
            return oldStr;
        } else {
            if (n > 3) {
                oldStr = oldStr.slice(0, oldStr.length - n - 3);
                oldStr += '...';
                return oldStr;
            } else {
                oldStr = '.'.repeat(n);
                return oldStr;
            }
        }
    };

    String.format = function (string, ...params) {
        let placeholderRegex = /{[0-9]+}/g;
        let matches = string.match(placeholderRegex);
        for (let i = 0; i < params.length; i++) {
            string = string.replace(matches[i], params[i]);
        }
        return string;
    }
})();

let text = 'the quick brown fox jumps over the lazy dog';
text = text.truncate(10);
console.log(text);
