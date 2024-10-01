<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Encuesta - Deportes, Libros y Comida</title>
</head>
<body>
    <h1>Deportes, Libros y Comida</h1>
    <form action="resultado.php" method="post">
        <input type="hidden" name="nombre" value="<?php echo $_POST['nombre']; ?>">
        <input type="hidden" name="apellido" value="<?php echo $_POST['apellido']; ?>">
        <input type="hidden" name="direccion" value="<?php echo $_POST['direccion']; ?>">
        <input type="hidden" name="email" value="<?php echo $_POST['email']; ?>">
        <input type="hidden" name="telefono" value="<?php echo $_POST['telefono']; ?>">
        <input type="hidden" name="sexo" value="<?php echo $_POST['sexo']; ?>">
        <input type="hidden" name="edad" value="<?php echo $_POST['edad']; ?>">
        <input type="hidden" name="estudios" value="<?php echo $_POST['estudios']; ?>">

        <label>Deporte:
            <select name="deporte" required>
                <option value="Fútbol">Fútbol</option>
                <option value="Tenis">Tenis</option>
                <option value="Vóley">Vóley</option>
                <option value="Básquet">Básquet</option>
            </select>
        </label><br>

        <label>Libros que lee:
            <select name="libros" required>
                <option value="Acción">Acción</option>
                <option value="Novelas">Novelas</option>
                <option value="Dramas">Dramas</option>
                <option value="Técnicos">Técnicos</option>
            </select>
        </label><br>

        <label>Comida que le gusta:
            <select name="comida" required>
                <option value="China">China</option>
                <option value="Vegetariana">Vegetariana</option>
                <option value="Pastas">Pastas</option>
            </select>
        </label><br>
        <input type="submit" value="Finalizar">
    </form>
</body>
</html>
