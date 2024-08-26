<?php

    // Realizar la suma de los 100 primeros números naturales, y mostrar el resultado
    // en pantalla.

    // Inicializar la variable que almacenará la suma
    $suma = 0;
    
    // Realizar la suma de los primeros 100 números naturales
    for ($i = 1; $i <= 100; $i++) {
        $suma += $i;
    }
    
    // Mostrar el resultado de la suma
    echo "La suma de los primeros 100 números naturales es: $suma";
?>