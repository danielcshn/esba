<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Suma de dos números</title>
</head>
<body>
    <h1>Suma de dos números naturales</h1>

    <!-- Formulario HTML para ingresar los números -->
    <form method="POST" action="">
        <label for="num1">Número 1:</label>
        <input type="number" id="num1" name="num1" required>
        <br><br>
        <label for="num2">Número 2:</label>
        <input type="number" id="num2" name="num2" required>
        <br><br>
        <input type="submit" value="Calcular Suma">
    </form>

    <?php
    // Comprobar si el formulario fue enviado
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        // Obtener los valores de los números del formulario
        $num1 = $_POST['num1'];
        $num2 = $_POST['num2'];

        // Realizar la suma de los números
        $suma = $num1 + $num2;

        // Mostrar el resultado en pantalla
        echo "<h2>Resultado: $num1 + $num2 = $suma</h2>";
    }
    ?>
</body>
</html>
