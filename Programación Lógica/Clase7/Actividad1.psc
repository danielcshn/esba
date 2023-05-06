Algoritmo Actividad1
	
	Definir Ventas1,Ventas2,VentasTotales,CantidadVentas1,CantidadVentas2,ImporteVendedor1,ImporteVendedor2 Como Entero

	Ventas1 = 0
	Ventas2 = 0
	VentasTotales = 0
	CantidadVentas1 = 0
	CantidadVentas2 = 0
	ImporteVendedor1 = 0
	ImporteVendedor2 = 0

	Repetir
		Escribir "Ingresar Codigo de Vendedor (1 / 2)"
		Leer CodigoVendedor
		
		Si CodigoVendedor <> 0 Entonces
			
			Escribir "Ingresar Codigo de Articulo"
			Leer CodigoArticulo
			Escribir "Ingresar Cantidad Vendida"
			Leer CantidadVendida
			Escribir "Ingresar Precio Unitario"
			Leer PrecioUnitario
			
			Si CodigoVendedor = 1 Entonces
				CantidadVentas1 = CantidadVentas1 + 1
				TotalVenta = PrecioUnitario * CantidadVendida
				ImporteVendedor1 = ImporteVendedor1 + TotalVenta
			SiNo
				CantidadVentas2 = CantidadVentas2 + 1
				TotalVenta = PrecioUnitario * CantidadVendida
				ImporteVendedor2 = ImporteVendedor2 + TotalVenta
			Fin Si
			
			VentasTotales = VentasTotales + TotalVenta
			
			Escribir "" 
			Escribir "Vendedor: ", CodigoVendedor, " | Codigo Articulo: ", CodigoArticulo, " | Importe Venta: ", TotalVenta
			Escribir "" 
			Escribir "Importe total de las ventas:"
			Escribir "Vendedor 1: ", ImporteVendedor1
			Escribir "Vendedor 2: ", ImporteVendedor2
			Escribir "" 
			Escribir "Importe Total Empresa: ", VentasTotales
			Escribir "" 
			Escribir "Cantidad de Ventas:"
			Escribir "Vendedor 1: ", CantidadVentas1
			Escribir "Vendedor 2: ", CantidadVentas2
			Escribir ""
		Fin Si
		
	Hasta Que CodigoVendedor = 0
	
FinAlgoritmo
