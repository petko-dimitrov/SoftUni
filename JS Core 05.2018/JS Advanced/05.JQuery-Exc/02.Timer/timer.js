function timer() {
    let start = $("#start-timer");
    let pause = $("#stop-timer");
    let interval;
    let hours = 0;
    let minutes = 0;
    let seconds = 0;
    let isSet = false;


    start.on('click', function () {
        if (!isSet) {
            interval = setInterval(incrementTime, 1000);
            isSet = true;
        }
    });

    pause.on('click', function () {
       clearInterval(interval);
       isSet = false;
    });

    function incrementTime() {
        seconds++;

        if (seconds === 60) {
            seconds = 0;
            minutes++;
        }
        if (minutes === 60) {
            minutes = 0;
            hours++;
        }

        $("#hours").text(("0" + hours).slice(-2));
        $("#minutes").text(("0" + minutes).slice(-2));
        $("#seconds").text(("0" + seconds).slice(-2));
    }
}