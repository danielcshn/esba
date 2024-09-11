<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores enviados desde el formulario
    $nombre = $_POST["nombre"];
    $edad = $_POST["edad"];
    $terminos = $_POST["terminos"];

    // Verificar si cumple con la edad y acepta los términos
    if ($edad >= 18 && $terminos == "si") {
        echo "Bienvenido $nombre al sistema.";
    } else {
        echo "$nombre, Ud. no puede ingresar al sistema.";
    }
}
?>
