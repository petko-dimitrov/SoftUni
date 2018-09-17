function calculateArea(width1, height1, width2, height2) {
    let area1 = width1 * height1;
    let area2 = width2 * height2;
    let areaMiddle = Math.min(width1, width2) * Math.min(height1, height2);
    let totalArea = area1 + area2 - areaMiddle;

    console.log(totalArea);
}

calculateArea(13, 2, 5, 8);