<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Obtener los valores enviados desde el formulario
    $num1 = $_POST["num1"];
    $num2 = $_POST["num2"];
    $operacion = $_POST["operacion"];
    $resultado = 0;

    // Realizar la operación seleccionada
    switch ($operacion) {
        case "sumar":
            $resultado = $num1 + $num2;
            break;
        case "restar":
            $resultado = $num1 - $num2;
            break;
        case "multiplicar":
            $resultado = $num1 * $num2;
            break;
        case "dividir":
            if ($num2 != 0) {
                $resultado = $num1 / $num2;
            } else {
                echo "Error: División por cero no permitida.";
                exit;
            }
            break;
        default:
            echo "Operación no válida.";
            exit;
    }

    // Mostrar el resultado
    echo "El resultado de la operación es: " . $resultado;
}
?>
