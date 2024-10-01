<?php
include 'funciones.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $monto = floatval($_POST['monto']);
    $iva = calcularIVA($monto);
    echo "<h1>Resultado del IVA</h1>";
    echo "<p>Monto ingresado: $$monto</p>";
    echo "<p>IVA (21%): $$iva</p>";
    echo "<p>Total con IVA: $" . ($monto + $iva) . "</p>";
} else {
    echo "Por favor, ingrese un monto.";
}
?>
