(function solve() {
    let solution = {
        'add': function (vec1, vec2) {
            let arr = [];
            arr.push(vec1[0] + vec2[0]);
            arr.push(vec1[1] + vec2[1]);
            return arr;
        },
        'multiply': function (vec1, scalar) {
            let arr = [];
            arr.push(vec1[0] * scalar);
            arr.push(vec1[1] * scalar);
            return arr;
        },
        'length': function (vec1) {
            return Math.sqrt(vec1[0] * vec1[0] + vec1[1] * vec1[1]);
        },
        'dot': function (vec1, vec2) {
            return vec1[0] * vec2[0] + vec1[1] * vec2[1];
        },
        'cross': function (vec1, vec2) {
            return vec1[0] * vec2[1] - vec2[0] * vec1[1];
        }
    };

    return solution;
}());