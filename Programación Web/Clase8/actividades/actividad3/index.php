<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Encuesta - Datos Personales</title>
</head>
<body>
    <h1>Datos Personales</h1>
    <form action="estudios.php" method="post">
        <label>Nombre: <input type="text" name="nombre" required></label><br>
        <label>Apellido: <input type="text" name="apellido" required></label><br>
        <label>Dirección: <input type="text" name="direccion" required></label><br>
        <label>Email: <input type="email" name="email" required></label><br>
        <label>Teléfono: <input type="tel" name="telefono" required></label><br>
        <label>Sexo:
            <select name="sexo" required>
                <option value="Masculino">Masculino</option>
                <option value="Femenino">Femenino</option>
                <option value="Otro">Otro</option>
            </select>
        </label><br>
        <label>Edad: <input type="number" name="edad" required></label><br>
        <input type="submit" value="Siguiente">
    </form>
</body>
</html>
