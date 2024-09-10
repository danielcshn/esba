<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="UTF-8">
        <title>Formularios</title>
    </head>
    <body>
        <form action="procesar.php" method="POST">
            <label for="txt_nombre">Escriba su nombre:</label>
            <input type="text"name="txt_nombre">
            <input type="submit" value="Enviar">
        </form>

    <?php
        $nombre = $_POST['txt_nombre'];
        echo "Hola ".$nombre.", bienvenido a la web!";
    ?>

    </body>
</html>
