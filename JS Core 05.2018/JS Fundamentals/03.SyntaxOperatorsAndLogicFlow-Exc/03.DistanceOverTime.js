function findDistance(input) {
    let v1 = input[0];
    let v2 = input[1];
    let t = input[2] / 3600;
    let s1 = v1 * t;
    let s2 = v2 * t;
    let distance = Math.abs(s1 - s2) * 1000;
    console.log(distance);
}

findDistance([0, 60, 3600]);