<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores de los lados
    $lado1 = $_POST["lado1"];
    $lado2 = $_POST["lado2"];
    $lado3 = $_POST["lado3"];

    // Verificar el tipo de triángulo
    if ($lado1 == $lado2 && $lado2 == $lado3) {
        // Triángulo equilátero
        echo "El triángulo es equilátero. Todos sus lados son iguales.";
    } elseif ($lado1 == $lado2 || $lado1 == $lado3 || $lado2 == $lado3) {
        // Triángulo isósceles
        echo "El triángulo es isósceles. Tiene dos lados iguales.";
    } else {
        // Triángulo escaleno
        echo "El triángulo es escaleno. Todos sus lados son diferentes.";
    }
}
?>
