<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Calcular IVA</title>
</head>
<body>

    <form method="POST" action="">
        <label for="monto">Ingrese un monto en pesos: </label>
        <input type="number" id="monto" name="monto" step="0.01" required>
        <input type="submit" value="Calcular con IVA">
    </form>

    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $monto = $_POST['monto'];
        calcularIVA($monto);
    }

    function calcularIVA($monto) {
        $iva = $monto * 0.21; // Calcular el 21% del monto
        $totalConIva = $monto + $iva; // Sumar el IVA al monto original
        echo "<h3>Monto original: $$monto</h3>";
        echo "<h3>IVA (21%): $$iva</h3>";
        echo "<h3>Total con IVA: $$totalConIva</h3>";
    }
    ?>

</body>
</html>
