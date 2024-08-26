<?php

    // Realizar un programa que ingresando tres lados de un triángulo, almacenados
    // en tres variables distintas, me diga qué tipo de triangulo es (equilátero,
    // isósceles o escaleno).

    // Definir los tres lados del triángulo
    $lado1 = 5;
    $lado2 = 5;
    $lado3 = 5;
    
    // Verificar qué tipo de triángulo es
    if ($lado1 == $lado2 && $lado2 == $lado3) {
        echo "El triángulo es equilátero.";
    } elseif ($lado1 == $lado2 || $lado1 == $lado3 || $lado2 == $lado3) {
        echo "El triángulo es isósceles.";
    } else {
        echo "El triángulo es escaleno.";
    }
?>