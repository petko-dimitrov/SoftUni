function convertToDegrees(grads) {
    let degrees =(grads * 0.9) % 360;

    if(degrees < 0){
        degrees += 360;
    }

    console.log(degrees);
}

convertToDegrees(-50);