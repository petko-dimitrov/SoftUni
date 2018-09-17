function insideOrOutside(input) {
    let [x, y, xMin, xMax, yMin, yMax] = input;

    let isInside = x >= xMin && x <= xMax && y >= yMin && y <= yMax;

    if (isInside){
        console.log("inside");
    } else {
        console.log("outside");
    }
}

insideOrOutside([8, -1, 2, 12, -3, 3]);