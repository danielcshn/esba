Algoritmo comercio
	resp = "S"
	totalPuntos = 0
	Mientras resp = "S" o resp = "s" Hacer
		Escribir "Ingrese nombre del cliente: "
		Leer nombre
		Escribir "Ingrese el valor de la compra: "
		Leer importe
		Si importe > 5000 Entonces
			puntos = importe * 5 / 100
		SiNo
			puntos = 0
		Fin Si
		totalPuntos = totalPuntos + puntos
		Escribir "Nombre: ", nombre, " Puntos: ", puntos
		Escribir "Quiere ingresar otro cliente (S/N)?"
		Leer resp
	Fin Mientras
	Escribir "Total otorgado de puntos en el dia: ", totalPuntos
FinAlgoritmo
