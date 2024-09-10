<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores enviados desde el formulario
    $nombre = $_POST["nombre"];
    $apellido = $_POST["apellido"];
    $telefono = $_POST["telefono"];
    $email = $_POST["email"];

    // Mostrar la frase personalizada
    echo "Bienvenido al sistema $nombre $apellido, su teléfono es: $telefono y su e-mail es: $email.";
}
?>
