function solve(matrix) {
    let rectangles = [];

    for (let i = 0; i < matrix.length; i++) {
        matrix[i] = {
            width: matrix[i][0],
            height: matrix[i][1],
            area: function () {
                return this.width * this.height;
            },
            compareTo: function (otherRect) {
                return otherRect.area() - this.area() || otherRect.width - this.width;
            }
        };

        rectangles.push(matrix[i]);
    }

    rectangles.sort((a, b) => a.compareTo(b));
    return rectangles;
}

solve([[10,5], [3,20], [5,12]]);