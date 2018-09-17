function attachEventsListeners() {
    let convertBtn = document.getElementById('convert');
    convertBtn.addEventListener('click', convert);
    
    function convert() {
        let inputUnit = document.getElementById('inputUnits').value;
        let outputUnit = document.getElementById('outputUnits').value;
        let input = Number(document.getElementById('inputDistance').value);
        let output = document.getElementById('outputDistance');
        let result = 0;

        switch (inputUnit) {
            case 'km': result = input * 1000; break;
            case 'm': result = input; break;
            case 'cm': result = input * 0.01; break;
            case 'mm': result = input * 0.001; break;
            case 'mi': result = input * 1609.34; break;
            case 'yrd': result = input * 0.9144; break;
            case 'ft': result = input * 0.3048; break;
            case 'in': result = input * 0.0254; break;
            default: break;
        }

        switch (outputUnit) {
            case 'km': result = result / 1000; break;
            case 'cm': result = result / 0.01; break;
            case 'mm': result = result / 0.001; break;
            case 'mi': result = result / 1609.34; break;
            case 'yrd': result = result / 0.9144; break;
            case 'ft': result = result / 0.3048; break;
            case 'in': result = result / 0.0254; break;
            default: break;
        }

        output.value = result;
    }
}