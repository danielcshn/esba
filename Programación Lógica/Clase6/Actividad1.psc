Algoritmo Actividad1
	
	// 1) Dadas 15 edades y nombres mostrar por pantalla el nombre con mayor edad
	
	edadmayor = 0
	nombremayor = ""
	
	Para i = 1 Hasta 15 Con Paso 1 Hacer
		Escribir "Ingrese Nombre: "
		Leer nombre
		Escribir "Ingrese Edad: "
		Leer edad
		
		Si edad > edadmajor Entonces
			edadmajor = edad
			nombremayor = nombre
		Fin Si
		
	Fin Para
	
	Escribir "Major edad es: ", nombremayor
FinAlgoritmo
