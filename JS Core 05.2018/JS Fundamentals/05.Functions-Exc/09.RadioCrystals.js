function solve(input) {
    let targetThickness = input[0];
    let currentThickness = 0;

    for (let i = 1; i < input.length; i++) {
        let thickness = input[i];
        console.log(`Processing chunk ${thickness} microns`);

        if (isDone(thickness, targetThickness)){
            continue;
        }

        if (thickness / 4 <= thickness - 20) {                  //cut
            currentThickness = cut(thickness, targetThickness);
            if(currentThickness !== thickness) {
                thickness = currentThickness;
                thickness = transportAndWash(thickness);
                if (isDone(thickness,targetThickness)){
                    continue;
                }
            }
            if (thickness * 0.8 <= thickness - 20) {            //lap, grind, etch
                currentThickness = lap(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                currentThickness = grind(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                currentThickness = etch(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
            }  else {
                currentThickness = grind(thickness, targetThickness); //grind
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                if (thickness * 0.8 <= thickness - 2) {             //lap, etch
                    currentThickness = lap(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                    currentThickness = etch(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                } else {                                       //etch, lap
                    currentThickness = etch(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                    currentThickness = lap(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                }
            }
        }

        else {                                                //grind
            currentThickness = grind(thickness, targetThickness);
            if(currentThickness !== thickness) {
                thickness = currentThickness;
                thickness = transportAndWash(thickness);
                if (isDone(thickness,targetThickness)){
                    continue;
                }
            }
            if (thickness / 4 <= thickness - 2) {             //cut
                currentThickness = cut(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                if (thickness * 0.8 <= thickness - 2){        //lap, etch
                    currentThickness = lap(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                    currentThickness = etch(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                } else {                                      //etch, lap
                    currentThickness = etch(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                    currentThickness = lap(thickness, targetThickness);
                    if(currentThickness !== thickness) {
                        thickness = currentThickness;
                        thickness = transportAndWash(thickness);
                        if (isDone(thickness,targetThickness)){
                            continue;
                        }
                    }
                }
            } else {                                           //etch, cut, lap
                currentThickness = etch(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                currentThickness = cut(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
                currentThickness = lap(thickness, targetThickness);
                if(currentThickness !== thickness) {
                    thickness = currentThickness;
                    thickness = transportAndWash(thickness);
                    if (isDone(thickness,targetThickness)){
                        continue;
                    }
                }
            }
        }
    }

    function lap(thickness, targetThickness) {
        let counter = 0;
        while (thickness - 0.2 * thickness >= targetThickness) {
            thickness = thickness - 0.2 * thickness;
            counter++;
        }

        if (counter > 0) {
            console.log(`Lap x${counter}`);
        }
        return thickness;
    }

    function cut(thickness, targetThickness) {
        let counter = 0;
        while (thickness / 4 >= targetThickness) {
            thickness = thickness / 4;
            counter++;
        }
        if (counter > 0) {
            console.log(`Cut x${counter}`);
        }
        return thickness;
    }

    function grind(thickness, targetThickness) {
        let counter = 0;
        while (thickness - 20 >= targetThickness) {
            thickness -= 20;
            counter++;
        }
        if (counter > 0) {
            console.log(`Grind x${counter}`);
        }
        return thickness;
    }

    function etch(thickness, targetThickness) {
        let counter = 0;
        while (thickness - 2 >= targetThickness - 1) {
            thickness -= 2;
            counter++;
        }
        if (counter > 0) {
            console.log(`Etch x${counter}`);
        }
        return thickness;
    }

    function xray(thickness) {
        thickness++;
        console.log(`X-ray x1`);
        return thickness;
    }

    function transportAndWash(thickness) {
        console.log("Transporting and washing");
        thickness = Math.floor(thickness);
        return thickness;
    }

    function isDone(thickness, targetThickness) {
        if (thickness < targetThickness) {
            thickness = xray(thickness);
        }

        if (thickness === targetThickness) {
            console.log(`Finished crystal ${targetThickness} microns`);
            return true;
        }
        return false;
    }
}

solve([10, 30]);