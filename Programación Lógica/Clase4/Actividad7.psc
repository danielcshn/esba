Algoritmo Actividad7
	
	// Un maestro desea conocer el porcentaje de hombres y mujeres hay en un grupo de estudiantes. 
	// Para ello se ingresa el número de hombres y de mujeres del grupo. 
	// Mostrar por pantalla el porcentaje solicitado
	
	Escribir "Ingresar la cantidad de Hombres: "
	Leer hombres
	Escribir "Ingresar la cantidad de Mujeres: "
	Leer mujeres
	
	total = hombres+mujeres
	
	totalh = (hombres*100)/total
	totalm = (mujeres*100)/total
	
	Escribir "% de hombres: ", redon(totalh)
	Escribir "% de mujeres: ", redon(totalm)
	
FinAlgoritmo
