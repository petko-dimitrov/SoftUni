function findTriangleArea(sideA, sideB, sideC) {
    let semiP = (sideA + sideB + sideC) / 2;
    let area = Math.sqrt(semiP * (semiP - sideA) * (semiP - sideB) * (semiP - sideC));
    console.log(area);
}

findTriangleArea(2, 3.5, 4);