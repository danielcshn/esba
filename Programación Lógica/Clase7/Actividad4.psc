Algoritmo Actividad4
	
	cc = 0
	ca = 0
	extr = 0
	depositos = 0
	
	Escribir "Ingrese la edad del cliente (cero para terminar): "
	leer edad

	Mientras edad <> 0		
		Escribir "Ingrese tipo de cuenta a la que deposita (CC o CA): "
		Leer cta
		cta = Mayusculas(cta)
		Escribir "Ingrese la nacionalidad (argentino, extranjero): "
		Leer nac
		nac = Mayusculas(nac)
		Escribir "Ingrese el saldo de la cuenta: "
		leer saldo
		depositos = depositos + saldo
		
		si cta = "CC" Entonces
			cc = cc + 1
			si	nac <> "ARGENTINO" O nac = "ARGENTINA" Entonces
				extr = extr + 1
			FinSi
		SiNo
			ca = ca + 1
		FinSi
		
		Escribir ""
		Escribir "Ingrese la edad del nuevo cliente (cero para terminar): "
		leer edad
	FinMientras

	clientes = cc + ca
	si clientes <> 0 Entonces
		Escribir ""
		Escribir "Cantidad de clientes con cuenta corriente: ", cc
		Escribir ""	
		Escribir "Promedio de importes ingresados: ",redon(depositos/clientes)
		Escribir ""
		Escribir "Porcentajes de clientes extranjeros con cuenta corriente: ",redon((extr * 100) / clientes),  "%"
	FinSi
	
FinAlgoritmo
