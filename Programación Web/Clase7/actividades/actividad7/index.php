<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Recomendar una página a un amigo</title>
</head>
<body>

    <h2>Recomendar una página a un amigo</h2>

    <form method="POST" action="">
        <label for="nombre_remitente">Su Nombre: </label>
        <input type="text" id="nombre_remitente" name="nombre_remitente" required><br><br>

        <label for="email_remitente">Su E-mail: </label>
        <input type="email" id="email_remitente" name="email_remitente" required><br><br>

        <label for="nombre_amigo">Nombre de su amigo: </label>
        <input type="text" id="nombre_amigo" name="nombre_amigo" required><br><br>

        <label for="email_amigo">E-mail de su amigo: </label>
        <input type="email" id="email_amigo" name="email_amigo" required><br><br>

        <input type="submit" value="Enviar Recomendación">
    </form>

    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $nombre_remitente = $_POST['nombre_remitente'];
        $email_remitente = $_POST['email_remitente'];
        $nombre_amigo = $_POST['nombre_amigo'];
        $email_amigo = $_POST['email_amigo'];

        // 1. Enviar correo al amigo con la recomendación personalizada
        $para_amigo = $email_amigo;
        $asunto_amigo = "$nombre_remitente te recomienda una página web";
        $mensaje_amigo = "Hola $nombre_amigo,\n\n$nombre_remitente te ha recomendado esta página web. ¡Échale un vistazo!\n\nSaludos,\nEl equipo de nuestra página.";
        $cabeceras_amigo = "From: $email_remitente";

        // mail($para_amigo, $asunto_amigo, $mensaje_amigo, $cabeceras_amigo); // Enviar correo a amigo

        // 2. Enviar correo de agradecimiento al remitente
        $para_remitente = $email_remitente;
        $asunto_remitente = "Gracias por recomendar nuestra página";
        $mensaje_remitente = "Hola $nombre_remitente,\n\nGracias por recomendar nuestra página a tu amigo $nombre_amigo.\n\nSaludos,\nEl equipo de nuestra página.";
        $cabeceras_remitente = "From: no-reply@nuestrositio.com";

        // mail($para_remitente, $asunto_remitente, $mensaje_remitente, $cabeceras_remitente); // Enviar correo de agradecimiento al remitente

        // 3. Enviar correo al dueño del sitio para recopilar direcciones
        $para_dueno = "dueno@nuestrositio.com";
        $asunto_dueno = "Nueva recomendación enviada";
        $mensaje_dueno = "El usuario $nombre_remitente ($email_remitente) ha recomendado nuestra página a $nombre_amigo ($email_amigo).";
        $cabeceras_dueno = "From: no-reply@nuestrositio.com";

        // mail($para_dueno, $asunto_dueno, $mensaje_dueno, $cabeceras_dueno); // Enviar correo al dueño del sitio

        // Mensaje de confirmación en la página
        echo "<h3>¡Gracias por usar nuestros servicios, $nombre_remitente! Tu recomendación ha sido enviada a $nombre_amigo.</h3>";
    }
    ?>

</body>
</html>
