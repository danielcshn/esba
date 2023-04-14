Algoritmo Actividad5
	
	Escribir "Ingresar las horas trabajadas:"
	Leer horas
	
	Escribir "Ingresar la categoria:"
	Leer categoria
	
	Sueldo = 0
	
	Segun categoria Hacer
		1:
			Sueldo = (horas * 12) - ((horas*12)*0.20)
		2:
			Sueldo = (horas * 15) - ((horas*12)*0.20)
		3:
			Sueldo = (horas * 18) - ((horas*12)*0.20)
		4:
			Sueldo = (horas * 20) - ((horas*12)*0.20)
		5:
			Sueldo = (horas * 25) - ((horas*12)*0.20)
		6:
			Sueldo = (horas * 28) - ((horas*12)*0.20)
		7:
			Sueldo = (horas * 30) - ((horas*12)*0.20)
		De Otro Modo:
			
	Fin Segun
	
	Escribir "Sueldo es: $", Sueldo
	
FinAlgoritmo
