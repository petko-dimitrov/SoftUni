function solve(input) {
    let [x1, y1, x2, y2, x3, y3] = input;
    let distance1To2 = findDistance(x1, y1, x2, y2);
    let distance2To3 = findDistance(x2, y2, x3, y3);
    let distance1To3 = findDistance(x1, y1, x3, y3);
    
    let totalDistance = distance1To2 + distance2To3;
    let result = `1->2->3: ${totalDistance}`;

    if (totalDistance > distance1To3 + distance2To3) {
        totalDistance = distance1To3 + distance2To3;
        result = `1->3->2: ${totalDistance}`;
    }

    if (totalDistance > distance1To2 + distance1To3){
        totalDistance = distance1To2 + distance1To3;
        result = `2->1->3: ${totalDistance}`;
    }

    if (totalDistance > distance2To3 + distance1To3){
        result = `2->3->1: ${totalDistance}`;
    }

    console.log(result);

    function findDistance(x1, y1, x2, y2) {
        return Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));
    }
}

solve([-1, -2, 3.5, 0, 0, 2]);