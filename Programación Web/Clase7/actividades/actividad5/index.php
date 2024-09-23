<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Formulario de Suscripción</title>
</head>
<body>

    <h2>Formulario de Suscripción</h2>

    <form method="POST" action="">
        <label for="nombre">Ingrese su Nombre: </label>
        <input type="text" id="nombre" name="nombre" required><br><br>

        <label for="edad">Ingrese su edad: </label>
        <input type="number" id="edad" name="edad" required><br><br>

        <label for="email">Ingrese su e-mail: </label>
        <input type="email" id="email" name="email" required><br><br>

        <input type="radio" id="acepto" name="condiciones" value="acepto" required>
        <label for="acepto">Acepto las condiciones de uso</label><br>

        <input type="radio" id="no_acepto" name="condiciones" value="no_acepto">
        <label for="no_acepto">No acepto las condiciones de uso</label><br><br>

        <input type="submit" value="Enviar">
    </form>

    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $nombre = $_POST['nombre'];
        $edad = $_POST['edad'];
        $email = $_POST['email'];
        $condiciones = $_POST['condiciones'];

        if ($edad >= 18 && $condiciones === 'acepto') {
            $para = "suscripcion@gmail.com";
            $asunto = "Envío de suscripción";
            $mensaje = "Nombre: $nombre\nEdad: $edad\nEmail: $email";
            $cabeceras = "From: $email";

            // Enviar el correo (comentado para evitar errores en entornos sin servidor de correo)
            // mail($para, $asunto, $mensaje, $cabeceras);

            echo "<h3>Gracias por suscribirse, $nombre</h3>";
        } else {
            echo "<h3>Ud. no puede suscribirse!</h3>";
        }
    }
    ?>

</body>
</html>
