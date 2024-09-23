<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Tabla de Multiplicar</title>
</head>
<body>

    <form method="POST" action="">
        <label for="numero">Elija una tabla de multiplicar (0 a 10): </label>
        <input type="number" id="numero" name="numero" min="0" max="10" required>
        <input type="submit" value="Mostrar Tabla">
    </form>

    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $numero = $_POST['numero'];
        mostrarTablaMultiplicar($numero);
    }

    function mostrarTablaMultiplicar($num) {
        echo "<h3>Tabla del $num:</h3>";
        for ($i = 0; $i <= 10; $i++) {
            $resultado = $num * $i;
            echo "$num x $i = $resultado<br>";
        }
    }
    ?>

</body>
</html>
