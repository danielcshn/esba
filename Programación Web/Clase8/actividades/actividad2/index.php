<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcular IVA</title>
</head>
<body>
    <h1>Ingrese un monto para calcular el IVA (21%)</h1>
    <form action="resultado.php" method="post">
        <input type="number" name="monto" step="0.01" required>
        <input type="submit" value="Calcular IVA">
    </form>
</body>
</html>
