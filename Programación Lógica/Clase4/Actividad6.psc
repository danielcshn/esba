Algoritmo Actividad6
	
    // Se ingresan 3 números: A, B y C. Si A es distinto de B y de C sumarlos. 
	// Si B es mayor que A, realizar la resta entre ambos números. 
	// Si B es igual a C, realizar la multiplicación entre ambos números. 
	// Mostrar resultados por pantalla.
	
	Escribir "Ingresar numero A: "
	Leer numA
	Escribir "Ingresar numero B: "
	Leer numB
	Escribir "Ingresar numero C: "
	Leer numC
	
	Si numA <> numB Y numA <> numC  Entonces
		Escribir ">> Si A es distinto de B y de C sumarlos."
		Escribir "Resultado ", (numA+numB+numC)
	Fin Si
	
	Si numB > numA Entonces
		Escribir ">> Si B es mayor que A, realizar la resta entre ambos números."
		Escribir "Resultado ", (numB-numA)
	Fin Si
	
	Si numB = numC Entonces
		Escribir ">> Si B es igual a C, realizar la multiplicación entre ambos números."
		Escribir "Resultado ", (numB*numC)
	Fin Si
	
FinAlgoritmo
