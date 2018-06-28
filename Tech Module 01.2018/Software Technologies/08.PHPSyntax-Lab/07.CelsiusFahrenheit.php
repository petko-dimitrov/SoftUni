<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?php
    if(isset($_GET['cel'])){
        $celsius = floatval($_GET['cel']);
        $fahrenheit = $celsius * 1.8 + 32;
        $msgAfterCelsius = "$celsius &deg;C = $fahrenheit &deg;F";
        echo $msgAfterCelsius;
    }
    ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?php
    if(isset($_GET['fah'])){
        $fahrenheit = floatval($_GET['fah']);
        $celsius = 5/9 * ($fahrenheit - 32);
        $msgAfterFahrenheit = "$fahrenheit &deg;F = $celsius &deg;C";
        echo $msgAfterFahrenheit;
    }
    ?>
</form>

