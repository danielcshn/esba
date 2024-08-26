<?php

    // Realizar la tabla de multiplicar del número 7, del 1 al 10, y mostrar los
    // resultados por pantalla.

    // Definir el número para la tabla de multiplicar
    $numero = 7;
    
    // Generar la tabla de multiplicar del 1 al 10
    for ($i = 1; $i <= 10; $i++) {
        // Calcular el resultado de la multiplicación
        $resultado = $numero * $i;
        
        // Mostrar el resultado
        echo "$numero x $i = $resultado<br>";
    }
?>