<?php
session_start();

// Definir usuario y contraseña
$usuario_correcto = "USUARIO";
$contrasena_correcta = "CONTRASEÑA";

// Verificar si se envían los datos del formulario
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $usuario = $_POST['usuario'];
    $contrasena = $_POST['contrasena'];

    // Comprobar si los datos son correctos
    if ($usuario === $usuario_correcto && $contrasena === $contrasena_correcta) {
        $_SESSION['autenticado'] = true; // Marcar como autenticado
        header("Location: index.php"); // Redirigir a la encuesta
        exit();
    } else {
        echo "<p>Usuario o contraseña incorrectos.</p>";
        echo "<a href='login.php'>Intente nuevamente</a>";
    }
}
?>
