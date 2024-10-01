<?php
function mostrarTabla($numero) {
    echo "<h1>Tabla de multiplicar del $numero</h1>";
    echo "<table border='1'>";
    echo "<tr><th>Multiplicación</th><th>Resultado</th></tr>";
    for ($i = 0; $i <= 10; $i++) {
        $resultado = $numero * $i;
        echo "<tr><td>$numero x $i</td><td>$resultado</td></tr>";
    }
    echo "</table>";
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $numero = intval($_POST['numero']);
    mostrarTabla($numero);
} else {
    echo "Por favor, ingrese un número.";
}
?>
