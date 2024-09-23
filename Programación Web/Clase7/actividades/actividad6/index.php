<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Encuesta</title>
</head>
<body>

    <h2>Encuesta</h2>

    <form method="POST" action="">
        <label for="nombre">Nombre y Apellido: </label>
        <input type="text" id="nombre" name="nombre" required><br><br>

        <label for="edad">Edad: </label>
        <input type="number" id="edad" name="edad" required><br><br>

        <label>¿Dónde vive?: </label><br>
        <input type="radio" id="capital" name="residencia" value="capital" required>
        <label for="capital">Capital</label><br>
        <input type="radio" id="interior" name="residencia" value="interior">
        <label for="interior">Interior</label><br><br>

        <label for="trabajo">¿Cuál es su trabajo?: </label>
        <input type="text" id="trabajo" name="trabajo" required><br><br>

        <label for="tiempo_estudio">¿Hace cuánto que estudia?: </label>
        <input type="text" id="tiempo_estudio" name="tiempo_estudio" required><br><br>

        <label>¿Tiene conocimientos previos de programación web?: </label><br>
        <input type="radio" id="si_conocimientos" name="conocimientos_web" value="Sí" required>
        <label for="si_conocimientos">Sí</label><br>
        <input type="radio" id="no_conocimientos" name="conocimientos_web" value="No">
        <label for="no_conocimientos">No</label><br><br>

        <input type="submit" value="Enviar Encuesta">
    </form>

    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $nombre = $_POST['nombre'];
        $edad = $_POST['edad'];
        $residencia = $_POST['residencia'];
        $trabajo = $_POST['trabajo'];
        $tiempo_estudio = $_POST['tiempo_estudio'];
        $conocimientos_web = $_POST['conocimientos_web'];

        // Preparar el mensaje de correo
        $para = "encuesta@hotmail.com";
        $asunto = "Respuestas de la encuesta";
        $mensaje = "Nombre y Apellido: $nombre\n";
        $mensaje .= "Edad: $edad\n";
        $mensaje .= "Vive en: $residencia\n";
        $mensaje .= "Trabajo: $trabajo\n";
        $mensaje .= "Tiempo de estudio: $tiempo_estudio\n";
        $mensaje .= "Conocimientos previos de programación web: $conocimientos_web\n";
        $cabeceras = "From: $nombre";

        // Enviar el correo (comentar en entornos sin servidor de correo configurado)
        // mail($para, $asunto, $mensaje, $cabeceras);

        // Mostrar mensaje de agradecimiento
        echo "<h3>¡Gracias por contestar la encuesta!</h3>";
    }
    ?>

</body>
</html>
