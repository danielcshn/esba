<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>
<body>
    <h1>Iniciar Sesión</h1>
    <form action="autenticar.php" method="post">
        <label>Usuario: <input type="text" name="usuario" required></label><br>
        <label>Contraseña: <input type="password" name="contrasena" required></label><br>
        <input type="submit" value="Entrar">
    </form>
</body>
</html>
