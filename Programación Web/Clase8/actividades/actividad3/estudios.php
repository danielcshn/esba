<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Encuesta - Estudios Cursados</title>
</head>
<body>
    <h1>Estudios Cursados</h1>
    <form action="deportes.php" method="post">
        <input type="hidden" name="nombre" value="<?php echo $_POST['nombre']; ?>">
        <input type="hidden" name="apellido" value="<?php echo $_POST['apellido']; ?>">
        <input type="hidden" name="direccion" value="<?php echo $_POST['direccion']; ?>">
        <input type="hidden" name="email" value="<?php echo $_POST['email']; ?>">
        <input type="hidden" name="telefono" value="<?php echo $_POST['telefono']; ?>">
        <input type="hidden" name="sexo" value="<?php echo $_POST['sexo']; ?>">
        <input type="hidden" name="edad" value="<?php echo $_POST['edad']; ?>">

        <label>Estudios Cursados:
            <select name="estudios" required>
                <option value="Primario">Primario</option>
                <option value="Secundario">Secundario</option>
                <option value="Terciario">Terciario</option>
                <option value="Universitario">Universitario</option>
            </select>
        </label><br>
        <input type="submit" value="Siguiente">
    </form>
</body>
</html>
