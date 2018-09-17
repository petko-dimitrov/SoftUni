function attachGradientEvents() {
    let box = document.getElementById('gradient');
    box.addEventListener('mousemove', move);
    box.addEventListener('mouseout', out);

    function move(ev) {
        let power = ev.offsetX / (ev.target.clientWidth - 1);
        power = Math.trunc(100 * power);
        document.getElementById('result').textContent = power + "%";
    }

    function out(ev) {
        document.getElementById('result').textContent = '';
    }
}