Algoritmo Actividad6
	
    // Se ingresan 3 n�meros: A, B y C. Si A es distinto de B y de C sumarlos. 
	// Si B es mayor que A, realizar la resta entre ambos n�meros. 
	// Si B es igual a C, realizar la multiplicaci�n entre ambos n�meros. 
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
		Escribir ">> Si B es mayor que A, realizar la resta entre ambos n�meros."
		Escribir "Resultado ", (numB-numA)
	Fin Si
	
	Si numB = numC Entonces
		Escribir ">> Si B es igual a C, realizar la multiplicaci�n entre ambos n�meros."
		Escribir "Resultado ", (numB*numC)
	Fin Si
	
FinAlgoritmo
