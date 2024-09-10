<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores enviados desde el formulario
    $nombre = $_POST["nombre"];
    $edad = $_POST["edad"];

    // Verificar la edad y mostrar el mensaje correspondiente
    if ($edad >= 18) {
        echo "Bienvenido $nombre al sistema.";
    } else {
        echo "$nombre, Ud. no puede ingresar al sistema.";
    }
}
?>
