function calcConeVolumeAndSurface(radius, height) {
    let volume = Math.PI * radius * radius * height / 3;
    let slant = Math.sqrt(radius * radius + height * height);
    let area = Math.PI * radius * slant + Math.PI * radius * radius;
    console.log("volume = " + volume);
    console.log("area = " + area);
}

calcConeVolumeAndSurface(3.3, 7.8);