<?php
session_start();

// Verificar si el usuario está autenticado
if (!isset($_SESSION['autenticado'])) {
    // Si no está autenticado, redirigir al login
    header("Location: login.php");
    exit();
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nombre = $_POST['nombre'];
    $apellido = $_POST['apellido'];
    $direccion = $_POST['direccion'];
    $email = $_POST['email'];
    $telefono = $_POST['telefono'];
    $sexo = $_POST['sexo'];
    $edad = $_POST['edad'];
    $estudios = $_POST['estudios'];
    $deporte = $_POST['deporte'];
    $libros = $_POST['libros'];
    $comida = $_POST['comida'];

    echo "<h1>Resultados de la Encuesta</h1>";
    echo "<p>Ud es: $nombre $apellido,</p>";
    echo "<p>Dirección: $direccion,</p>";
    echo "<p>Email: $email,</p>";
    echo "<p>Teléfono: $telefono,</p>";
    echo "<p>Sexo: $sexo,</p>";
    echo "<p>Edad: $edad años,</p>";
    echo "<p>Tiene estudios de: $estudios,</p>";
    echo "<p>Le gusta practicar: $deporte,</p>";
    echo "<p>Le gusta leer: $libros,</p>";
    echo "<p>Le gusta la comida: $comida.</p>";
} else {
    echo "No se recibieron datos.";
}
?>
