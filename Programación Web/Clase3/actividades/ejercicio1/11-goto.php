<?php

    // Utilizando el operador goto, realizar una suma de dos variables, y una
    // multiplicación, saltarse la suma y mostrar en pantalla el resultado de la
    // multiplicación.

	// Definir dos variables
	$a = 4;
	$b = 5;
	
	// Operación de suma (será saltada)
	$sum = $a + $b;
	
	goto skip_sum; // Saltar la suma y continuar después de esta etiqueta
	
	// Mostrar el resultado de la suma (este código será ignorado)
	echo "La suma de $a y $b es: $sum<br>";
	
	skip_sum: // Etiqueta para saltar
	// Operación de multiplicación
	$mult = $a * $b;
	
	// Mostrar el resultado de la multiplicación
	echo "La multiplicación de $a y $b es: $mult";
?>