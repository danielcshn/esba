<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="UTF-8">
        <title>Formularios</title>
    </head>
    <body>
    <form action="procesar.php" method="POST">
        <label for="txt_n1">Ingrese Número 1:</label>
        <input type="text"name="txt_n1"><br>
        <label for="txt_n2">Ingrese Número 2:</label>
        <input type="text"name="txt_n2"><br><br>
        <input type="submit" value="Sumar">
    </form>

    <?php
        $resultado = $_POST['txt_n1'] +
        $_POST['txt_n2'];
        echo "El resultado de la suma es:
        ".$resultado;
    ?>

    </body>
</html>
